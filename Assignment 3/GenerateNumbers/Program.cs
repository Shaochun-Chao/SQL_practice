namespace GenerateNumbers
{
    public class program
    {
        public static void Main(string[] args)
        {


            //int[] numbers = GenerateNumbers(10); 
            //Reverse(numbers); 
            //PrintNumbers(numbers);


            Fibonacci(10);
        }

        public static int[] GenerateNumbers(int len )
        {
            int[] numbers = new int[len];
            for(int i = 0; i < len; i++)
            {
                numbers[i] = i+1;
            }

            return numbers;
        }

        public static void Reverse(int[] arr)
        {
            arr.Reverse();
            Console.Write($"Reverse: ");
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }

        }

        public static void PrintNumbers(int[] arr)
        {
            Console.WriteLine();
            Console.Write($"Number: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
        }

        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            int a = 1, b = 1, c = 0;
            for (int j = 3; j <= n; j++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(c);
            return c;


        }

    }

}