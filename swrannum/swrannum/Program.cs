namespace swrannum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your number is: ");
            int number = new Random().Next(1, 6);
            
            switch (number)
                {
                case 1:
                    Console.WriteLine(number);
                    break;
                case 2:
                    Console.WriteLine(number);
                    break;
                case 3:
                    Console.WriteLine(number);
                    break;
                case 4:
                    Console.WriteLine(number);
                    break;
                case 5:
                    Console.WriteLine(number);
                    break;
                case 6:
                    Console.WriteLine(number);
                    break;
                   default:
                    Console.WriteLine("Wrong one");
                    break;
            }
           
        }
    }
}
