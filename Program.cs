namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
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
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Неправильное действие!!! Повторите еще.");
                    break;
            }
            Console.WriteLine("Ответ {0}", result);
            Console.ReadKey();
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