namespace OverloadedMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O', };

            Console.WriteLine("Array intArray contains:");
            DisplayArray(intArray);
            Console.WriteLine("Array doubleArray contains:");
            DisplayArray(doubleArray);
            Console.WriteLine("Array charArray contains:");
            DisplayArray(charArray);
        }

        // Output int array
        private static void DisplayArray(int[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        // Output double array
        private static void DisplayArray(double[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        // Output char array
        private static void DisplayArray(char[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}