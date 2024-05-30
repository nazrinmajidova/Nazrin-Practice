namespace LoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task3();
            Task2();
            Task1();

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

       
    }
}
