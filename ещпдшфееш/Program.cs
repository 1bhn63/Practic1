using System;

class Calculator
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Калькулятор");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                double number1, number2;
                double result = 0;

                switch (choice)
                {
                    // Операции сложения, вычитания, умножения и деления
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.Write("Введите первое число: ");
                        number1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        number2 = double.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                result = number1 + number2;
                                break;
                            case 2:
                                result = number1 - number2;
                                break;
                            case 3:
                                result = number1 * number2;
                                break;
                            case 4:
                                if (number2 != 0)
                                    result = number1 / number2;
                                else
                                    Console.WriteLine("Деление на ноль недопустимо.");
                                break;
                        }
                        break;

                    // Возведение в степень
                    case 5:
                        Console.Write("Введите число: ");
                        number1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        int exponent = int.Parse(Console.ReadLine());
                        result = Math.Pow(number1, exponent);
                        break;

                    // Квадратный корень
                    case 6:
                        Console.Write("Введите число: ");
                        number1 = double.Parse(Console.ReadLine());
                        if (number1 >= 0)
                            result = Math.Sqrt(number1);
                        else
                            Console.WriteLine("Извлечение корня из отрицательного числа недопустимо.");
                        break;

                    // Нахождение 1% от числа
                    case 7:
                        Console.Write("Введите число: ");
                        number1 = double.Parse(Console.ReadLine());
                        result = number1 * 0.01;
                        break;

                    // Вычисление факториала
                    case 8:
                        Console.Write("Введите число: ");
                        number1 = double.Parse(Console.ReadLine());
                        result = CalculateFactorial(number1);
                        break;

                    // Выход из программы
                    case 9:
                        exit = true;
                        break;

                    // Неверный выбор
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }

                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 1 до 9.");
            }
        }
    }
    static double CalculateFactorial(double n)
    {
        if (n < 0)
        {
            throw new Exception("Факториал отрицательного числа недопустим.");
        }

        if (n == 0)
        {
            return 1;
        }
        else
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}