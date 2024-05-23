namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practice1();
            Practice2();
        }

        public static void Practice1() //ingilis dilinde daxil edilmis fesil adinin az dilindeki qarsiligi
        {
            Console.Write("Write a season : ");
            string season = Console.ReadLine().ToLower();

            string movsum = season switch
            {
                "winter" => "qis",
                "spring" => "yaz",
                "summer" => "yay",
                "autumn" => "payiz",
                _ => "Incorrect input"
            };
            Console.WriteLine(movsum);
        }

        public static void Practice2()
        {
            Console.Write("Write a season : ");
            string season2 = Console.ReadLine().ToLower();
            string result = "";
            //string result = string empty; 

            switch (season2)
            {
                case "winter":
                    result = "qis";
                    break;
                case "autumn":
                    result = "payiz";
                    break;
                case "spring":
                    result = "yaz";
                    break;
                case "summer":
                    result = "yay";
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }

            Console.WriteLine(result);

        }
    }
}
