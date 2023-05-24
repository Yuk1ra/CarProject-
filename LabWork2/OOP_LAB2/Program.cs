using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Choose the Task: ");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                {
                   Task1(out int[] arr1);
                   break;
                }
                case 2:
                {
                    Task2(out int[] arr2);
                    break;
                }
                case 3:
                {
                    Task1(out int[] arr1);
                    Task2(out int[] arr2);
                    Task3(arr1, arr2, out int[] arr3);
                    break;
                }
                case 4:
                {
                    Task1(out int[] arr1);
                    Task2(out int[] arr2);
                    Task3(arr1,arr2,out int[] arr3);
                    Task4(arr3);
                    break;
                }
                case 5:
                {
                    Task1(out int[] arr1);
                    Task2(out int[] arr2);
                    Task3(arr1,arr2,out int[] arr3);
                    Task5(arr3);
                    break;
                }
                case 6:
                {
                    Task6(out int[,] arr6, out int numberOfEmployees);
                    break;
                }
                case 7:
                {
                    Task6(out int[,] arr6, out int numberOfEmployees);
                    Task7(arr6,numberOfEmployees);
                    break;
                }
                case 8:
                {
                    Task8();
                    break;
                }
                case 9:
                {
                    Task9();
                    break;
                }
                default:
                {
                    Console.WriteLine("There is no a task in this number!");
                    break;
                }
            }
        }

        public static void Task1(out int[] arr)
        {
            try
            {
                arr = new int[10];
                Console.Write("\nWrite a number of arrays alements: ");
                uint ArrayEllements = uint.Parse(Console.ReadLine());
                Array.Resize(ref arr, (int)ArrayEllements);
                Algorithms.GenerateOneDimensionalArray(arr);
                Console.WriteLine("\nNon-sorted array");
                Algorithms.PrintOneDimensionalArray(arr);
                Algorithms.BubbleSortMinToMax(arr);
                Console.WriteLine("\nSorted array");
                Algorithms.PrintOneDimensionalArray(arr);
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!!!");
                throw;
            }


        }

        public static void Task2(out int[] arr)
        {
            try
            {
                Console.Write("\n\nWrite a range of masive to sort it: ");
                int N = int.Parse(Console.ReadLine());
                arr = Algorithms.SieveOfEratosthenes(N);
                Console.WriteLine("==============");
                Algorithms.PrintOneDimensionalArray(arr);
            }
            catch (Exception)
            {
                Console.WriteLine("Error!!!");
                throw;
            }

        }

        public static void Task3(int[] arr1, int[] arr2,out int[] arr3)
        {
            try
            {
                Console.WriteLine("\nAdding two arrays");
                arr3 = Algorithms.AddTwoArrays(arr1,arr2);
                Algorithms.PrintOneDimensionalArray(arr3);

                int SumArray=Algorithms.SumArray(arr3);
                Console.WriteLine("\nThe Summary of array is: " +SumArray);

                double average = arr3.Average();
                Console.WriteLine("\nThe avarage number of array is: "+ average);

                int min = arr3.Min();
                int max = arr3.Max();
                Console.WriteLine("\nThe min. number is: "+min+"\nThe max. nuber is:" +max);
            }
            catch (Exception)
            {
                Console.WriteLine("Error!!!");
                throw;
            }

        }

        public static void Task4(int[] arr3)
        {
            try
            {
                Console.Write("\nEnter the element to search: ");
                int searchValue = int.Parse(Console.ReadLine());

                for (int i = 0; i < arr3.Length; i++)
                {
                    if (arr3[i] == searchValue)
                    {
                        Console.WriteLine($"\nElement found at index {i}");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!!!");
                throw;
            }

        }

        public static void Task5(int[] arr3)
        {
            try
            {
                Console.Write("\nWrite an element you want to find index of it: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int index = Algorithms.BinarySearch(arr3, x);
                if (index == -1) {
                    Console.WriteLine("\nМодифiкувати функцiю двiйкового пошуку у масивi, використавши метод  BinarySearch класу Array");
                } else {
                    Console.WriteLine("\nThe elements index is: " + index);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!!!");
                throw;
            }

        }

        public static void Task6(out int[,] matrixsalaries, out int numberOfEmployees)
        {
            try
            {
                int numberOfMonths = 12;
                Console.Write("Write a number of employees: ");
                numberOfEmployees = int.Parse(Console.ReadLine());
                matrixsalaries = new int[numberOfEmployees, numberOfMonths];

                Random rand = new Random();
                for (int i = 0; i < numberOfEmployees; i++)
                {
                    for (int j = 0; j < numberOfMonths; j++)
                    {
                        matrixsalaries[i, j] = rand.Next(1000, 5000);
                    }
                }

                Console.WriteLine("\nMatrix salary:");
                for (int i = 0; i < numberOfEmployees; i++)
                {
                    for (int j = 0; j < numberOfMonths; j++)
                    {
                        Console.Write(matrixsalaries[i, j] + "\t");
                    }

                    Console.WriteLine();
                }

                int totalBudget = 0;

                for (int i = 0; i < numberOfEmployees; i++)
                {
                    for (int j = 0; j < numberOfMonths; j++)
                    {
                        totalBudget += matrixsalaries[i, j];
                    }
                }

                Console.WriteLine("\nTotal budget per year: " + totalBudget);
                Console.Write("\nWrite a number of month: ");
                int monthNumber = int.Parse(Console.ReadLine());
                int totalSalaryForMonth = 0;
                for (int i = 0; i < numberOfEmployees; i++)
                {
                    totalSalaryForMonth += matrixsalaries[i, monthNumber - 1]; // -1, оскільки місяці нумеруються з 0
                }

                Console.WriteLine("\nTotal salary for month: " + monthNumber + ": " + totalSalaryForMonth);

                double averageSalaryForMonth = (double)totalSalaryForMonth / numberOfEmployees;
                Console.WriteLine("\nAverage salary for month: " + monthNumber + ": " + averageSalaryForMonth);
            }

            catch (Exception)
            {
                Console.WriteLine("Error!!!");
                throw;
            }
        }


        public static void Task7(int[,] matrixsalaries, int numberOfEmployees)
        {
            try
            {
// знаходимо рядок з мінімальним та максимальним значеннями
            int numberOfMonth = 12;
            int minRowIndex = 0, maxRowIndex = 0;
            int min = matrixsalaries[0, 0];
            int max = matrixsalaries[0, 0];
            for (int i = 0; i < numberOfEmployees; i++)
            {
                for (int j = 0; j < numberOfEmployees; j++)
                {
                    if (matrixsalaries[i, j] < min)
                    {
                        min = matrixsalaries[i, j];
                        minRowIndex = i;
                    }
                    if (matrixsalaries[i, j] > max)
                    {
                        max = matrixsalaries[i, j];
                        maxRowIndex = i;
                    }
                }
            }
            // перевіряємо, чи мінімальний та максимальний елементи в одному рядку
            if (minRowIndex == maxRowIndex)
            {
                // якщо так, знаходимо стовпці, де знаходяться ці елементи
                int minColumnIndex = 0, maxColumnIndex = 0;
                for (int j = 0; j < numberOfMonth; j++)
                {
                    if (matrixsalaries[minRowIndex, j] == min)
                    {
                        minColumnIndex = j;
                    }
                    if (matrixsalaries[maxRowIndex, j] == max)
                    {
                        maxColumnIndex = j;
                    }
                }
                // міняємо місцями стовпці
                for (int i = 0; i < numberOfMonth; i++)
                {
                    int temp = matrixsalaries[i, minColumnIndex];
                    matrixsalaries[i, minColumnIndex] = matrixsalaries[i, maxColumnIndex];
                    matrixsalaries[i, maxColumnIndex] = temp;
                }
            }
            else
            {
                // якщо ні, міняємо місцями рядки
                for (int j = 0; j < numberOfEmployees; j++)
                {
                    int temp = matrixsalaries[minRowIndex, j];
                    matrixsalaries[minRowIndex, j] = matrixsalaries[maxRowIndex, j];
                    matrixsalaries[maxRowIndex, j] = temp;
                }
            }
            Console.WriteLine("\nMatrix after swap:");
            for (int i = 0; i < numberOfEmployees; i++)
            {
                for (int j = 0; j < numberOfMonth; j++)
                {
                    Console.Write($"{matrixsalaries[i, j], 4}\t");
                }
                Console.WriteLine();
            }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!!!");
                throw;
            }

        }
        public static void Task8()
        {
            try
            {
            /*Спочатку потрібно виразити рівняння у вигляді f(x) = 0. У нашому випадку це:
            f(x) = (x^26*x)^22(x3)^2 - 81
            Тепер потрібно обчислити похідну f(x)
            f'(x) = 22(x^26x)^21 * (x^26 + 26x^25x') * (x3)^2 + 44(x^26*x)^22 * x^26 * (x3) * x2
            Для методу Ньютона потрібно вибрати початкове наближення x0 і використовувати обчислення наступного наближення xi+1:
            xi+1 = xi - f(xi) / f'(xi)
            Повторюємо цю формулу, поки |xi+1 - xi| > ε, де ε - малий додатний числовий параметр, що вказує на точність результату.*/

                double x = 1; // початкове наближення
                double epsilon = 0.000001; // точність результату
                double fx = 0, fpx = 0, xi = 0;

                do
                {
                    xi = x;
                    fx = Math.Pow(Math.Pow(Math.Pow(x, 26) * x, 22) * Math.Pow(x, 3), 2) - 81;
                    fpx = 22 * Math.Pow(Math.Pow(Math.Pow(x, 26) * x, 21) * (Math.Pow(x, 26) + 26 * Math.Pow(x, 25)), 2) * Math.Pow(Math.Pow(x, 3), 2)
                          + 44 * Math.Pow(Math.Pow(Math.Pow(x, 26) * x, 22) * Math.Pow(x, 26) * Math.Pow(x, 3), 2) * Math.Pow(x, 2);
                    x = xi - fx / fpx;
                } while (Math.Abs(x - xi) > epsilon);

                Console.WriteLine("The root of the equation: {0}", x);
                Console.WriteLine("Checking: {0}", Math.Pow(Math.Pow(Math.Pow(x, 26) * x, 22) * Math.Pow(x, 3), 2));

                //Використовуємо цикл do-while для обчислення xi+1, доки різниця між xi та xi+1 більше, ніж ε.
                //У нашому випадку, ми обрали початкове наближення x
            }
            catch (Exception)
            {
                Console.WriteLine("Error!!!");
                throw;
            }

        }

        public static void Task9()
        {
            try
            {
                Console.Write("Write a line: ");
                string input = Console.ReadLine();
                Console.WriteLine("Entered line : {0}", input);
                Console.Write("Enter a search string: ");
                string search = Console.ReadLine();
                Console.Write("Enter a substring to replace: ");
                string replace = Console.ReadLine();


                if (input.Contains(search))
                {
                    string output = input.Replace(search, replace);
                    Console.WriteLine("The result of the replacement: {0}", output);
                }

                else
                {
                    Console.WriteLine("No search string found.");
                }

                Console.Write("Enter a substring to insert: ");
                string insert = Console.ReadLine();
                Console.Write("Enter the index to insert: ");
                int index = int.Parse(Console.ReadLine());
                string result = input.Insert(index, insert);
                Console.WriteLine("The result of the insertion: {0}", result);
                Console.Write("Enter the substring to delete: ");
                string delete = Console.ReadLine();
                string output2 = input.Replace(delete, " ");
                Console.WriteLine("Result of deletion: {0}", output2);
            }
            catch (Exception)
            {
                Console.WriteLine("Error!!!");
                throw;
            }
        }
    }

    internal class Algorithms
    {
        public static int[] AddTwoArrays(int[] arr1, int[] arr2)
        {
            int[] ResultForTask3 = new int [Math.Max(arr1.Length, arr2.Length)];
            for (int i = 0; i < ResultForTask3.Length; i++)
            {
                /* Робимо перевірку для масиву в якого меньше елементів та присвоюємо для нього значення 0 */
                int a = i < arr1.Length ? arr1[i] : 0;
                int b = i < arr2.Length ? arr2[i] : 0;
                ResultForTask3[i] = a + b;
            }

            return ResultForTask3;
        }
        public static void GenerateOneDimensionalArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = rand.Next(0, 100);
            }
        }
        public static int[] SieveOfEratosthenes(int n)
        {
            bool[] prime = new bool[n + 1];

            // заповнюємо масив prime значеннями true
            for (int i = 0; i <= n; i++)
            {
                prime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                // Якщо prime[p] не змінене, тоді p - просте число
                if (prime[p] == true)
                {
                    // Міняємо значення всіх кратних p чисел, починаючи з p*p
                    for (int i = p * p; i <= n; i += p)
                    {
                        prime[i] = false;
                    }
                }
            }

            // Створюємо масив простих чисел
            int count = 0;
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                {
                    count++;
                }
            }

            int[] primes = new int[count];
            int index = 0;

            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                {
                    primes[index] = i;
                    index++;
                }
            }

            return primes;
        }
        public static void PrintOneDimensionalArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
        }
        public static void BubbleSortMinToMax(int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
        public static int SumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
        public static int BinarySearch(int[] arr, int x)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                else if (arr[mid] < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // елемент не знайдено
        }
    }
}