using System;

namespace LastFactorialDigit
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberOfTests = EnterAPositiveInteger();

            int[] numbers = InitializeAnArray(numberOfTests);
            FillArrayWithNumbers(numbers);

            int[] factorials = FactorialOverArray(numbers);
            char[] myChars = LastStringCharOverIntArray(factorials);
            PrintCharArray(myChars);

        }

        // -------------------------------------------------------------------

        private static void PrintCharArray(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        private static char[] LastStringCharOverIntArray(int[] a)
        {
            char[] res = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                res[i] = LastStringChar(ConvertNumber2String(a[i]));
            }
            return res;
        }

        private static char LastStringChar(String str)
        {
            return str[str.Length - 1];
        }

        private static String ConvertNumber2String(int a)
        {
            return a.ToString();
        }


        // ==================================================================

        private static int[] FactorialOverArray(int[] arr)
        {
            int[] res = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = Factorial(arr[i]);
            }
            return res;
        }

        private static int Factorial(int a)
        {
            if (a == 1)
                return 1;
            else return a * Factorial(a - 1);
        }


        private static void FillArrayWithNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = EnterAPositiveInteger();
            }
        }

        private static int[] InitializeAnArray(int size)
        {
            int[] arr = new int[size];
            return arr;
        }

        private static int EnterAPositiveInteger()
        {
            int result = 0;
            try
            {
                result = int.Parse(Console.ReadLine());
                if (result < 1 || result > 10)
                    throw new ArgumentException();
                return result;
            }
            catch (ArgumentException ex)
            {
                return ErrorHandling();
            }
            catch (FormatException ex)
            {
                return ErrorHandling();
            }
        }
        private static int ErrorHandling()
        {
            Console.WriteLine("Please enter valid integer");
            return EnterAPositiveInteger();
        }

    } 
}


