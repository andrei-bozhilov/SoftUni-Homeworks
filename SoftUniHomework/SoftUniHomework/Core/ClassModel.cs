namespace SoftUniHomework.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ClassModel : IComparable<ClassModel>
    {
        public ClassModel(string name, float orderNumber)
        {
            this.Name = name;
            this.OrderNumber = orderNumber;
        }

        public string Name { get; set; }

        public float OrderNumber { get; set; }

        public int CompareTo(ClassModel other)
        {
            return this.OrderNumber.CompareTo(other.OrderNumber);
        }
    }
}
