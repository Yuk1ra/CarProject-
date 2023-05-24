using System;

namespace LabWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            Console.Write("\nВиберiть завдання лабораторно: ");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
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
                default:
                    Console.WriteLine("В лабораторнiй лише 5 завдань!");
                    break;
            }
        }
        static void Task1()
        {
            try
            {
                Console.WriteLine("Пушкарук "+ "Назар "+"17 "+"IПЗ-12 "+"ООП "+"nazarpushk@gmail.com");
                int a = 2;
                int b = 3;
                int c = 4;
                int d = 5;
                Console.Write("\nThe variable x= ");
                double x = double.Parse(Console.ReadLine());
                double result = a * Math.Pow(x,4) - b * Math.Pow(x,3) + c * x + d;
                Console.Write("Your result p = ");
                Console.WriteLine(result); 
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                throw;
            }
           
        }
        static void Task2()
        {
            try
            {
                Console.Write("\nThe variable a= ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("The variable b= ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("The variable c= ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("The variable d= ");
                double d = double.Parse(Console.ReadLine());
                double x = a + b;
                double y = Math.Sin(c) - Math.Cos(d);
                if (y < 0)
                {
                    Console.WriteLine("The root can`t be negative!!!");
                    return;
                }
                double result=Math.Pow(x,2)/Math.Sqrt(y);
                Console.Write("Your result, x = "+ result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                throw;
            }
        }
        static void Task3()
        {
            try
            {
                Console.WriteLine("\nWrite the variable x = ");
                int x = int.Parse(Console.ReadLine());
                if (x>0)
                {
                    Console.WriteLine(4*x-1);
                }
                else if(x<0)
                {
                    Console.WriteLine(25*x+10);
                }
                else if (x == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine("Error!");
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                throw;
            }
            
        }
        static void Task4()
        {
            try
            {
                Console.Write("\nWrite a number of a day");
                int numberDay = int.Parse(Console.ReadLine());
                switch (numberDay)
                {
                    case 1:
                        Console.WriteLine("It`s Monday!");
                        break;
                    case 2:
                        Console.WriteLine("It`s Tuesday!");
                        break;
                    case 3:
                        Console.WriteLine("It`s Wednesday!");
                        break;
                    case 4:
                        Console.WriteLine("It`s Thursday!");
                        break;
                    case 5:
                        Console.WriteLine("It`s Friday!");
                        break;
                    case 6:
                        Console.WriteLine("It`s Saturday!");
                        break;
                    case 7:
                        Console.WriteLine("It`s Sunday!");
                        break;
                    default:
                        Console.Write("There are only 7 day names! Not ");
                        Console.WriteLine(numberDay);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                throw;
            }
            
        }
        static void Task5()
        {
            try
            {
                Console.Write("\nWrite the number of diapazon:");
                int N = int.Parse(Console.ReadLine()); 
                int sum = 0; 
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("value= ");
                    int a = int.Parse(Console.ReadLine());
                    if (a > N)
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    sum += a;
                }
                Console.Write("Sum is: ");
                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                throw;
            }
        }
    }
}