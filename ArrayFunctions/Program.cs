namespace ArrayFunctions; 

internal class Program
{
    static void Main ( string[] args)
    {
        //Task4();     //minimum ededi tapan 
        //Task3();    //minimum ededin indexini tapan 
        //Task2();   // arrayin ortalamasini tapan 
        SimpComp();  // arrayin elementlerinin sade olanlari bir arraye, murekkeb olanlari digerine elave ele. Sonda her birini ekrana cixar.

    }

    public static void Task4()
    {
        int[] arr = { 0, 50, -11, 23, 18 };
        int minimum = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (minimum > arr[i])
            {
                minimum = arr[i];
            }
        }
        Console.WriteLine(minimum);
    }

    public static void Task3()
    {
        int[] arr2 = { 0, 50, -11, 23, 18 };
        int minimum = arr2[0];
        for (int i = 1; i < arr2.Length; i++)
        {
            if (minimum > arr2[i])
            {
                minimum = arr2[i];
            }
        }
        Console.WriteLine(Array.IndexOf(arr2, minimum));
    }

    public static void Task2()
    {
        int[] arr3 = { 0, 50, -11, 23, 18 };
        int sum = 0;
        int count = 0;
        for (int i = 0; i < arr3.Length; i++)
        {
            sum += arr3[i];
            count++;
        }
        int mean = sum / count;
        Console.WriteLine(mean);

    }

    public static void SimpComp()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int bolenSayi = 2;
        int bolen = 2;
        if( num > 1)
        {
            if( num != 2)
            {
                if(num / 2 == bolen)
                {
                    if (num % bolen == 0) {
                        bolenSayi++;
                        bolen++;
                    } else
                    {
                        bolen++; 
                    }

                } else if (bolenSayi > 2)
                {
                    Console.WriteLine("eded murekkeb ededdir"); 
                } else
                {
                    Console.WriteLine("eded sade ededdir");
                }
            } else
            {
                Console.WriteLine("2 en kicik sade ededdir"); 
            }
        }
        else
        {
            Console.WriteLine("Eded ne sadedir , ne murekkeb");
        }
    } 


}


