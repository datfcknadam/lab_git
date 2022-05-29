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
            float action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое число");
            float input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            float input_2 = Convert.ToInt32(Console.ReadLine());
            float result = 0;
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
            Console.ReadKey();
        }
        //Сложение  
        public static float Addition(float input_1, float input_2)
        {
            float result = input_1 + input_2;
            return result;
        }
        // Вычитание  
        public static float Subtraction(float input_1, float input_2)
        {
            float result = input_1 - input_2;
            return result;
        }
        //Умножение  
        public static float Multiplication(float input_1, float input_2)
        {
            float result = input_1 * input_2;
            return result;
        }
        //Деление  
        public static float Division(float input_1, float input_2)
        {
            float result = input_1 / input_2;
            return result;
        }
    }
}