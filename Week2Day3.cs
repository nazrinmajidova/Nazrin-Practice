namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Practice1();
            Practice2();
            Practice3();

        }

        public static void Practice1()
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");
                }

            }
            else
            {
                Console.WriteLine("The number is not natural");

            }
        }

        public static void Practice2()
        {
            int number = int.Parse( Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            } else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            } else
            {
                Console.WriteLine("The number is equal to zero");
            }
        }

        public static void Practice3 ()
        {
            int GPA = int.Parse( Console.ReadLine());

            if (GPA > 91)
            {
                Console.WriteLine("The student's GPA is more than 91");
            } else
            {
                Console.WriteLine("The student's GPA is not more than 91");
            }
        }
    }
}
