namespace SoftUniHomework.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using SoftUniHomework.Attributes;

    public class ReflectionReader
    {
        /// <summary>
        /// Filter for specific namespace, and exclude system methods such as toString()
        /// </summary>
        /// <param name="namespaceFilterBy">Name of namespace you want</param>
        /// <param name="methodNameExcluded">Name of methods you don't want</param>
        public ReflectionReader(IEnumerable<string> namespaceFilterBy = null, IEnumerable<string> methodNameExcluded = null)
        {
            this.AssemblyClassesMethods = new Dictionary<Type, MethodInfo[]>();
            this.AssemblyClassesMethodsNames = new Dictionary<ClassModel, MethodModel[]>();
            this.GetAllClassesMethods(namespaceFilterBy, methodNameExcluded);
        }

        public Dictionary<Type, MethodInfo[]> AssemblyClassesMethods { get; private set; }

        public Dictionary<ClassModel, MethodModel[]> AssemblyClassesMethodsNames { get; private set; }

        private void GetAllClassesMethods(IEnumerable<string> namespaceFilterBy = null,
            IEnumerable<string> methodNameExcluded = null)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            var classTypes = currentAssembly.GetTypes();

            foreach (var classType in classTypes)
            {
                if (namespaceFilterBy == null || namespaceFilterBy.Any(x => x == classType.Namespace))
                {
                    this.AssemblyClassesMethods
                        .Add(classType, classType.GetMethods().ToArray());
                }
                else
                {
                    continue;
                }

                string[] classTypeMethodsNames;

                if (methodNameExcluded != null)
                {
                    classTypeMethodsNames =
                    classType.GetMethods().Select(x => x.Name).Except(methodNameExcluded).ToArray();
                }
                else
                {
                    classTypeMethodsNames =
                   classType.GetMethods().Select(x => x.Name).ToArray();
                }

                var classAttribute = this.GetAttributeInfoForClass(classType);
                MethodModel[] methodModels = new MethodModel[classTypeMethodsNames.Length];

                for (int i = 0; i < classTypeMethodsNames.Length; i++)
                {
                    var methodAttribute =
                        this.GetAttributeInfoForMethod(classType.Name, classTypeMethodsNames[i]);

                    methodModels[i] =
                        new MethodModel(
                            classTypeMethodsNames[i],
                            methodAttribute.PositionNumber,
                            methodAttribute.TaskDescription,
                            methodAttribute.SourceCode);
                }

                Array.Sort(methodModels);

                this.AssemblyClassesMethodsNames
                        .Add(new ClassModel(classType.Name, classAttribute.PositionNumber), methodModels);
            }
        }

        private MethodInfo FindMethod(string className, string methodName)
        {
            if (string.IsNullOrWhiteSpace(className) || string.IsNullOrWhiteSpace(methodName))
            {
                throw new ArgumentException("Class name or method name can't be null, empty or white space.");
            }

            var currentClass =
                this.AssemblyClassesMethods.Keys.First(x => x.Name == className);
            var currentMethod =
                this.AssemblyClassesMethods[currentClass].FirstOrDefault(x => x.Name == methodName);

            if (currentMethod == null)
            {
                throw new MissingMemberException("There is no such method.");
            }
            return currentMethod;
        }

        public string ExcuteMethod(string className, string methodName, string[] methodParameters = null)
        {
            var currentMethod = this.FindMethod(className, methodName);
            return (currentMethod.Invoke(this, methodParameters)).ToString();
        }

        private TaskDescriptionAttribute GetAttributeInfoForClass(string className)
        {
            var currentClass =
                this.AssemblyClassesMethods.Keys
                .Where(x => x.Name == className)
                .FirstOrDefault();

            if (currentClass.GetCustomAttribute<TaskDescriptionAttribute>() == null)
            {
                throw new ArgumentException("There is no attribute of type TaskDescriptionAttribute for this class.");
            }

            return currentClass.GetCustomAttribute<TaskDescriptionAttribute>();
        }

        private TaskDescriptionAttribute GetAttributeInfoForClass(Type currentClass)
        {
            if (currentClass.GetCustomAttribute<TaskDescriptionAttribute>() == null)
            {
                throw new ArgumentException("There is no attribute of type TaskDescriptionAttribute for this class.");
            }

            return currentClass.GetCustomAttribute<TaskDescriptionAttribute>();
        }

        public TaskDescriptionAttribute GetAttributeInfoForMethod(string className, string methodName)
        {
            var currentMethod = this.FindMethod(className, methodName);
            if (currentMethod.GetCustomAttribute<TaskDescriptionAttribute>() == null)
            {
                throw new ArgumentException("There is no attribute of type TaskDescriptionAttribute for this method.");
            }

            return currentMethod.GetCustomAttribute<TaskDescriptionAttribute>();
        }

        public TaskDescriptionAttribute GetAttributeInfoForMethod(MethodInfo methodName)
        {
            if (methodName.GetCustomAttribute<TaskDescriptionAttribute>() == null)
            {
                throw new ArgumentException("There is no attribute of type TaskDescriptionAttribute for this method.");
            }

            return methodName.GetCustomAttribute<TaskDescriptionAttribute>();
        }
    }
}
