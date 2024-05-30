using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Task3();
                Task2();
                Task1();
                Task4(); 
                Task7();
             */
            ForEach();

        }

        public static void Task3() 
        {  //ededin reqemlerinin ceminin ve nece reqemli olmasinin tapilmasi.
            Console.WriteLine("Eded daxil edin : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
            int remainder = 0;
            while(num > 0)
            {
                remainder = num % 10;
                sum += remainder;
                num = num - remainder; 
                num = num / 10;
                count++;

            }
            Console.WriteLine(sum);
            Console.WriteLine(count);   
        }

        public static void Task2()
        {
            int[] arr = { 57, 7, 2, 4, 0, 21, 3, 6, 11 };
            int min = arr[0];
            int max = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if(  arr[i] < min ) min = arr[i];
                if( arr[i] > max ) max = arr[i];
            }

            Console.WriteLine(min);
            Console.WriteLine(max);

        }

        public static void Task1()
        {
            Console.WriteLine("Array olcusu daxil edin:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");
            int[] arr2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\nIndex{i}:");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int even = 0;
            int odd = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] % 2 == 0) even++;
                else odd++;
            }
            Console.WriteLine(even);
            Console.WriteLine(odd);
        }

        public static void Task4()
        {
            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i< value; i++)
            {
                for (int j = 0;  j< value; j++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();    
            }
        }

       public static void Task7()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                   Console.WriteLine("{0}x{1} = {2}", j, i, i * j); 

                }
                Console.WriteLine(new string('-', 10));
                Console.Write("\n");
            }
       }

        public static void Task6()
        {
            int value2 = Convert.ToInt32(Console.ReadLine());

            
        }

        public static void ForEach()
        {
            int[] array = { 3, 7, 6, 12, 24, 76, 98, 43, 11 };
            int count = 0;
            foreach (int nums in array)
            {
                if (nums % 2 == 0 && nums % 3 == 0) count++;
                
            }
            Console.WriteLine(count);
        }
    }
}
