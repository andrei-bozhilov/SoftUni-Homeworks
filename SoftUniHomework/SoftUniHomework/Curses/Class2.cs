namespace SoftUniHomework.Curses
{
    using SoftUniHomework.Attributes;

    [TaskDescriptionAttribute(2)]
    public static class Class2
    {
        [TaskDescriptionAttribute(2.1f)]
        public static string Method1()
        {
            return "1.1";
        }

        [TaskDescriptionAttribute(2.2f)]
        public static string Method2()
        {
            return "1.2";
        }

        [TaskDescriptionAttribute(2.3f)]
        public static string Method3()
        {
            return "1.3";
        }

        [TaskDescriptionAttribute(2.4f)]
        public static string Method4()
        {
            return "1.4";
        }
    }
}
