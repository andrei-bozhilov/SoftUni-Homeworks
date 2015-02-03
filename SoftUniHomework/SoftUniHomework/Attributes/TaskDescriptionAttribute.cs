namespace SoftUniHomework.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class TaskDescriptionAttribute : Attribute
    {
        public TaskDescriptionAttribute(float positionNumber, string taskDescription = null, string code = null)
        {
            this.PositionNumber = positionNumber;
            this.TaskDescription = taskDescription;
            this.SourceCode = code;
        }

        public float PositionNumber { get; set; }

        public string TaskDescription { get; set; }

        public string SourceCode { get; set; }
    }
}
