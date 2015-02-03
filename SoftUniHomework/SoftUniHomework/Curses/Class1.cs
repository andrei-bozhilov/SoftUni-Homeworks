using SoftUniHomework.Attributes;
namespace SoftUniHomework.Curses
{
    [TaskDescription(1)]
    public static class Class1
    {
        [TaskDescription(1.1f, "Make program Hello World!"
            , @"public static string HelloWorld()
        {
            return ""Hello World!"";
        }")]
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        [TaskDescription(1.2f)]
        public static string Method2()
        {
            return "2";
        }

        [TaskDescription(1.3f)]
        public static string Method3()
        {
            return "3";
        }

        [TaskDescription(1.4f)]
        public static string Method4()
        {
            return "4";
        }
    }
}
