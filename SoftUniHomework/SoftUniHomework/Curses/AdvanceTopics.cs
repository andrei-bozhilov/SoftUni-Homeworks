namespace SoftUniHomework.Curses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SoftUniHomework.Attributes;

    [TaskDescription(7f)]
    public static class AdvanceTopics
    {
        [TaskDescriptionAttribute(7.1f,
            "Define a method Fib(n) that calculates the nth Fibonacci number.",
@"public static string FibonaciNumbers(string input)
{
    int position;

    if (!int.TryParse(input, out position))
    {
        throw new ArgumentException(""Invalid input. Cannot parse string to number."");
    }

    ulong result = 0;

    if (position < 0)
    {
        throw new ArgumentException(""Cannot calculate negative number. Fibonaci numbers are positive!"");
    }

    if (position == 0)
    {
        return (1).ToString();
    }
    else if (position == 1)
    {
        return (1).ToString();
    }
    else
    {
        ulong a = 1;
        ulong b = 1;
        ulong c = a + b;

        for (int i = 0; i < position - 2; i++)
        {
            a = b;
            b = c;
            c = a + b;
        }

        result = c;
    }

    return result.ToString();
}")]
        public static string FibonaciNumbers(string input)
        {
            int position;

            if (!int.TryParse(input, out position))
            {
                throw new ArgumentException("Invalid input. Cannot parse string to number.");
            }

            ulong result = 0;

            if (position < 0)
            {
                throw new ArgumentException("Cannot calculate negative number. Fibonaci numbers are positive!");
            }

            if (position == 0)
            {
                return (1).ToString();
            }
            else if (position == 1)
            {
                return (1).ToString();
            }
            else
            {
                ulong a = 1;
                ulong b = 1;
                ulong c = a + b;

                for (int i = 0; i < position - 2; i++)
                {
                    a = b;
                    b = c;
                    c = a + b;
                }

                result = c;
            }

            return result.ToString();
        }
    }
}
