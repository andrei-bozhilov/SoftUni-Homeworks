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
        #region Description for Fibonaci Numbers Problem
        [TaskDescriptionAttribute(7.1f,
            "Define a method Fib(n) that calculates the nth Fibonacci number.Define a method Fib(n) that calculates the nth Fibonacci number.",
@"public static ulong FibonaciNumbers(string input)
{
int position;

if (input == null)
{
        throw new NullReferenceException(""Input is null"");
}

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
    return 1;
}
else if (position == 1)
{
    return 1;
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

return result;
}")]
        #endregion

        public static ulong FibonaciNumbers(string input)
        {
            int position;

            if (input == null)
            {
                throw new NullReferenceException("Input is null");
            }

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
                return 1;
            }
            else if (position == 1)
            {
                return 1;
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

            return result;
        }


        #region Description for Prime checker
        [TaskDescription(7.2f, "Write a method that check whether a given integer number n is prime",
@"public static Boolean IsPrime(string input)
{
    if (string.IsNullOrEmpty(input))
    {
        throw new ArgumentNullException();
    }

    int number = 0;

    if (!int.TryParse(input, out number))
    {
        throw new ArgumentException(""Cannot parse input."");
    }

    if (number <= 1)
    {
        return false;
    }
    else if (number == 2 || number == 3)
    {
        return true;
    }
    else if (number % 2 == 0 || number % 3 == 0)
    {
        return false;
    }
    else
    {
        int end = (int)Math.Sqrt(number);

        for (int i = 5; i <= end; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
        }
    }

    return true;
}")]
        #endregion
        public static Boolean IsPrime(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException();
            }

            int number = 0;

            if (!int.TryParse(input, out number))
            {
                throw new ArgumentException("Cannot parse input.");
            }

            if (number <= 1)
            {
                return false;
            }
            else if (number == 2 || number == 3)
            {
                return true;
            }
            else if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }
            else
            {
                int end = (int)Math.Sqrt(number);

                for (int i = 5; i <= end; i += 6)
                {
                    if (number % i == 0 || number % (i + 2) == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static Boolean IsPrime(int input)
        {
            int number = input;

            if (number <= 1)
            {
                return false;
            }
            else if (number == 2 || number == 3)
            {
                return true;
            }
            else if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }
            else
            {
                int end = (int)Math.Sqrt(number);

                for (int i = 5; i <= end; i += 6)
                {
                    if (number % i == 0 || number % (i + 2) == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        #region Description for Primes in Given range
        [TaskDescription(7.3f, "Write a method that calculates all prime numbers in given range and returns them as list of integers:",
@"public static Boolean IsPrime(int input)
{
    int number = input;

    if (number <= 1)
    {
        return false;
    }
    else if (number == 2 || number == 3)
    {
        return true;
    }
    else if (number % 2 == 0 || number % 3 == 0)
    {
        return false;
    }
    else
    {
        int end = (int)Math.Sqrt(number);

        for (int i = 5; i <= end; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
        }
    }

    return true;
}

public static string FindPrimeInRange(string startNum, string endNum)
{
    if (string.IsNullOrEmpty(startNum) || string.IsNullOrEmpty(endNum))
    {
        throw new ArgumentNullException();
    }

    int startNumber = 0;
    int endNumber = 0;

    if (!int.TryParse(startNum, out startNumber) || !int.TryParse(endNum, out endNumber))
    {
        throw new ArgumentException(""Cannot parse input"");
    }

    List<int> primesInRange = new List<int>();

    for (int i = startNumber; i <= endNumber; i++)
    {
        if (IsPrime(i))
        {
            primesInRange.Add(i);
        }
    }

    return string.Join("", "", primesInRange.ToArray());
}")]
        #endregion
        public static string FindPrimeInRange(string startNum, string endNum)
        {
            if (string.IsNullOrEmpty(startNum) || string.IsNullOrEmpty(endNum))
            {
                throw new ArgumentNullException();
            }

            int startNumber = 0;
            int endNumber = 0;

            if (!int.TryParse(startNum, out startNumber) || !int.TryParse(endNum, out endNumber))
            {
                throw new ArgumentException("Cannot parse input");
            }

            List<int> primesInRange = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    primesInRange.Add(i);
                }
            }

            return string.Join(", ", primesInRange.ToArray());
        }

        #region Description for Difference between Dates
        [TaskDescription(7.4f, "Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.",
@"public static int DefferenceInDate(string firstDate, string secondDate)
{
    if (string.IsNullOrEmpty(firstDate) || string.IsNullOrEmpty(secondDate))
    {
        throw new ArgumentNullException();
    }

    DateTime startDate = new DateTime();
    DateTime endDate = new DateTime();

    if (!DateTime.TryParse(firstDate, out startDate) || !DateTime.TryParse(secondDate, out endDate))
    {
        throw new ArgumentException(""Cannot parse input."");
    }

    TimeSpan dif = endDate - startDate;

    return dif.Days;
}")]
        #endregion
        public static int DefferenceInDate(string firstDate, string secondDate)
        {
            if (string.IsNullOrEmpty(firstDate) || string.IsNullOrEmpty(secondDate))
            {
                throw new ArgumentNullException();
            }

            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();

            if (!DateTime.TryParse(firstDate, out startDate) || !DateTime.TryParse(secondDate, out endDate))
            {
                throw new ArgumentException("Cannot parse input.");
            }

            TimeSpan dif = endDate - startDate;

            return dif.Days;
        }
    }
}
