using System;

class StartPage
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nВыбор действия:");
            Console.WriteLine("1 - Калькулятор топлива");
            Console.WriteLine("2 - Анализ персональных данных");
            Console.WriteLine("3 - Игра в кости");
            Console.WriteLine("4 - Расчет заработной платы");
            Console.WriteLine("0 - Выход");

            Console.Write("Введите номер: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Subfunctions.FuelCalculator();
                    break;

                case "2":
                    Console.Write("Введите личный код: ");
                    string id = Console.ReadLine();
                    Console.WriteLine(Subfunctions.HindaIsikkood(id));
                    break;

                case "3":
                    Subfunctions.TaringuMang();
                    break;

                case "4":
                    Console.Write("Введите брутто-зарплату: ");
                    if (double.TryParse(Console.ReadLine(), out double salary))
                    {
                        var result = Subfunctions.CalculateSalary(salary);
                        Console.WriteLine($"Необлагаемый доход: {result.Item1:F2} €");
                        Console.WriteLine($"Чистая зарплата: {result.Item2:F2} €");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода!");
                    }
                    break;

                case "0":
                    Console.WriteLine("Выход из программы...");
                    return;

                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
                    
            }  
        }
    }
}
