namespace SoftUniHomework.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MethodModel : IComparable<MethodModel>
    {
        public MethodModel(string name, float orderNumber, string description, string sourceCode)
        {
            this.Name = name;
            this.OrderNumber = orderNumber;
            this.Description = description;
            this.SourceCode = sourceCode;
        }

        public string Name { get; set; }

        public float OrderNumber { get; set; }

        public string Description { get; set; }

        public string SourceCode { get; set; }

        public int CompareTo(MethodModel other)
        {
            return this.OrderNumber.CompareTo(other.OrderNumber);
        }
    }
}
