namespace switch;

internal class Program
{
    static void Main(string[] args)
    {
        string inp = Console.ReadLine();

        switch (inp)
        {
            case "a":
                Console.WriteLine("its a");
                break;
            case "b":
                Console.WriteLine("its b");
                break;
            case "c":
                Console.WriteLine("its c");
                break;
            default:
                Console.WriteLine("nothing here");
                break;
        }
    }
    }
}
