using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("что вы хотите сделать?");
            Console.WriteLine("1. сложение двух чисел");
            Console.WriteLine("2. вывод данных в обратном порядке");
            Console.WriteLine("3. умножение вещественных чисел (один знак после запятой)");
            Console.WriteLine("4. умножение трех вещественных числа (два знака после запятой)");
            Console.WriteLine("5. запрос четырех вещественных чисел с последующими расчетами (два знака после запятой)");
            Console.WriteLine("6. сложение, вычитание и умножение двух чисел");
            Console.WriteLine("7. расчеты с тремя числами");
            Console.WriteLine("8. расчеты с тремя вещественными числами (4 знака после запятой)");
            Console.WriteLine("9. деление вещественного числа на целое (4 знака после запятой)");
            Console.WriteLine("10. умножение вещественного числа в два столбика (1-ый: 3 знака после запятой)");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))

                switch (choice)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                case 7:
                    Task7();
                    break;
                case 8:
                    Task8();
                    break;
                case 9:
                    Task9();
                    break;
                case 10:
                    Task10();
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
        }

        static void Task1()
        {
            Console.WriteLine("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"{sum}");
        }

        static void Task2()
        {
            Console.WriteLine("a= ");
            string a = Console.ReadLine();
            Console.WriteLine("b= ");
            string b = Console.ReadLine();
            Console.WriteLine($"{b} + {a}");
        }

        static void Task3()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            double product = a * b;
            Console.WriteLine($"ответ: {product:F1}");
        }

        static void Task4()
        {
            Console.WriteLine("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            double c = double.Parse(Console.ReadLine());
            double product = a * b * c;
            Console.WriteLine($"ответ: {product:F2}");
        }

        static void Task5()
        {
            Console.WriteLine("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("d= ");
            double d = double.Parse(Console.ReadLine());
            double result = (a / b) + (b / c);
            Console.WriteLine($"result: {result:F2}");
        }

        static void Task6()
        {
            Console.WriteLine("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            int f = a * b; 
            Console.WriteLine($"a+b={a}+{b}={c}       a-b={a}-{b}={d}     a*b={a}*{b}={f}");
        }

        static void Task7() 
        {
            Console.WriteLine("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            int c = int.Parse(Console.ReadLine());
            int f = (b + c) * a;
            Console.WriteLine($"[{a}*({b}+{c})]=[{b}+{c}*{a}={f}]");
        }

        static void Task8() 
        {
            Console.WriteLine("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            double c = double.Parse(Console.ReadLine());
            double f = a + b + c;
            Console.WriteLine("(a+(b+c)=(a+b+c)={f:F4}");
        }

        static void Task9() 
        {
            Console.WriteLine("x= ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("y= ");
            int y = int.Parse(Console.ReadLine());
            double z = (x * 3) / y;
            Console.WriteLine("ответ: {z:F4}");
        }

        static void Task10() 
        {
            Console.WriteLine("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            double b = double.Parse(Console.ReadLine());
            double c = a * b;
            Console.WriteLine("ответ:{c:F3}         ответ:{F5}");
        }
    }
}
