using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniHomework.Core
{
    public class ReflectionReader
    {
        private List<Type> assemblyClasses;
        private List<MethodInfo> classMethods;

        public ReflectionReader()
        {
            this.assemblyClasses = new List<Type>();
            this.classMethods = new List<MethodInfo>();
            this.BannedClasses = new List<string>();
            this.BannedMethods = new List<string>();
            this.GetAllClasses();
        }

        public ReflectionReader(ICollection<string> bannedClassesNames, ICollection<string> bannedMethodsNames)
            : this()
        {
            this.BannedClasses = bannedClassesNames.ToList();
            this.BannedMethods = bannedMethodsNames.ToList();
        }

        public List<string> BannedClasses { get; set; }

        public List<string> BannedMethods { get; set; }

        private void GetAllClasses()
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            this.assemblyClasses = currentAssembly.GetTypes().ToList();
        }

        private void GetAllMethods(string className)
        {
            Type currentClass = Type.GetType(className);
            this.classMethods = currentClass.GetMethods().ToList();
        }

        public IEnumerable<string> GetAllClassesNames()
        {
            return this.assemblyClasses.Select(x => x.FullName);
        }

        public IEnumerable<string> GetAllMethodsNames(string className)
        {
            this.GetAllMethods(className);
            return this.classMethods.Select(x => x.Name);
        }

        public string ExcuteMethod(string className, string methodName)
        {
            var currentClass = Type.GetType(className);
            var currentMethod = currentClass.GetMethod(methodName);
            return (string)currentMethod.Invoke(this, null);
        }
    }
}
