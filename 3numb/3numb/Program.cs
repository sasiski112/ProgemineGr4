namespace _3numb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
                {
                case 1:
                    Console.WriteLine("1");
                    Console.Beep(567, 647);
                    break;
                    case 2:
                    Console.WriteLine("2");
                    Console.Beep(895, 121);
                    break;
                    case 3:
                    Console.WriteLine("3");
                    Console.Beep(563, 823);
                    break;
                    case 4:
                    Console.WriteLine("4");
                    Console.Beep(1000, 500);
                    Console.Beep(1000, 500);
                    break;  
            
            
            
            }
        }
    }
}
