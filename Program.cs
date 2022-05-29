namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Это SimpleCalc by Dany - калькулятор предназначенный для рассчета простых чисел с простыми действиями");
            Calc();
        }

        static void Calc()
        {
            Console.WriteLine("Введите действие для рассчета");
            Console.WriteLine("Введите 1 для сложения");
            Console.WriteLine("Введите 2 для вычитания");
            Console.WriteLine("Введите 3 для умножения");
            Console.WriteLine("Введите 4 для деления \n");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое число");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        if (input_2 == 0)
                        {
                            Console.WriteLine("Делить на ноль нельзя!!! Повторите еще.");
                            break;
                        }
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Неправильное действие!!! Повторите еще.");
                    break;
            }
            Console.WriteLine("Ответ {0}", result);
            Console.WriteLine("Завершить работу программу (Y / N)?");
            while (true)
            {
                string answer = Console.ReadKey().KeyChar.ToString().ToLower();
                if (answer == "y")
                {
                    break;
                }
                if (answer == "n")
                {
                    Calc();
                    break;
                }
                Console.WriteLine("Введите (Y / N)");
            }
        }
        //Сложение  
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        // Вычитание  
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }
        //Умножение  
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }
        //Деление  
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 / input_2;
            return result;
        }
    }
}