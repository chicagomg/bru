using System;

namespace Labs_1
{
    class Program
    {
 /*       static void Task1_4()
        {
            Console.WriteLine("Please enter your number: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }*/
        static void Task2_1()
        {
            double alpha, zed1, zed2;
            Console.WriteLine("Задание 2.1");
            Console.WriteLine("Введите значение Альфа");
            alpha = Convert.ToDouble(Console.ReadLine());
            zed1 = ((Math.Sin(2 * alpha)) + (Math.Sin(5 * alpha)) - (Math.Sin(3 * alpha))) / (Math.Cos(alpha) + 1 - 2 * Math.Pow(Math.Sin(2 * alpha), 2));
            zed2 = 2 * Math.Sin(alpha);
            Console.WriteLine("z1 = " + zed1);
            Console.WriteLine("z2 = " + zed2);
        }
        static void Task4_1()
        {
            double x, y, z;
            Console.WriteLine("Задание 4.1");
            Console.WriteLine("Введите x и y");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (y != 0 && Math.Abs(x) > Math.Abs(y))
                z = Math.Atan(x / y);
            else if (y != 0 && Math.Abs(x) <= Math.Abs(y))
                z = Math.Asin(x / y);
            else
                z = 0;
            Console.WriteLine("При x={0:f1}, y={1:f1}, z={2:f5}", x, y, z);
        }
        static void Task4_2()
        {
            double A, B;
            Console.WriteLine("Задание 4.2");
            Console.WriteLine("Введите A и B");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            if (A > B)
            {
                B = B + A;
                A = B - A;
                B = B - A;
            }
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
        }
        static void Task6_1()
        {
            Console.WriteLine("Таблица значений для функции f(x)=cos(x) на отрезке от П/3 до 2П/3");
            Console.WriteLine("Задание 6.1");
            double f, x, Xn, Xk, dX;
            Xn = Math.PI / 3;
            Xk = Math.PI * 2 / 3;
            dX = (Xk - Xn) / 20;
            for (x = Xn; x <= Xk; x += dX)
            {
                f = Math.Cos(x);
                Console.WriteLine("x= {0,5:f13}, f(x)= {1,8:f5}", x, f);
            }
        }
        static void Task6_2()
        {
            double i, x, y, member, total;
            Console.WriteLine("Задание 6.2");
            total = 0;
            y = 1;
            for (i = 1; i <= 18; i++)
            {
                x = Math.Pow(i, 2);
                y *= i;
                member = x / y;
                total += member;
            }
            Console.WriteLine(total);
        }

        static void Task7_1()
        {
            double eps, member, total;
            Console.WriteLine("Задание 7.1");
            eps = 0.0001;
            total = 0;
            member = 1;
            while (member > eps / 2)
            {
                total += member;
                member /= 2;
            }
            Console.WriteLine(total);
        }
        static void Task9_1()
        {
            int n, i, prod, leftzero, rightzero, sum, j, swap;
            Console.WriteLine("Задание 9.1");
            int[] arr;
            Console.WriteLine("Введите длину массива");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            Console.WriteLine("Введите n элементов массива");
            for (i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            prod = 1;
            for (i = 0; i < n; i += 2)
                prod *= arr[i];
            Console.WriteLine("Произведение элементов с чётным номером = " + prod);
            leftzero = 0;
            while (arr[leftzero] != 0)
                leftzero++;
            rightzero = n - 1;
            while (arr[rightzero] != 0)
                rightzero--;
            sum = 0;
            for (i = leftzero + 1; i < rightzero; i++)
                sum += arr[i];
            Console.WriteLine("Сумма элементов между первым и последним нулями = " + sum);
            for (i = 0; i < n; i++)
                for (j = 1; j < n; j++)
                    if (arr[j - 1] < 0 && arr[j] >= 0)
                    {
                        swap = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = swap;
                    }
            Console.WriteLine("Переупорядоченный массив: ");
            for (i = 0; i < n; i++)
                Console.WriteLine(arr[i]);
        }
        static void Task11_1()
        {
            int n, i, j, prod;
            Console.WriteLine("Задание 11.1");
            int[,] arr;
            bool containsnegative;
            Console.WriteLine("Введите размер квадратной матрицы");
            n = int.Parse(Console.ReadLine());
            arr = new int[n, n];
            Console.WriteLine("Введите элементы матрицы");
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    arr[i, j] = int.Parse(Console.ReadLine());
            prod = 1;
            for (i = 0; i < n; i++)
            {
                containsnegative = false;
                for (j = 0; j < n; j++)
                    if (arr[i, j] < 0)
                        containsnegative = true;
                if (!containsnegative)
                {
                    for (j = 0; j < n; j++)
                        prod *= arr[i, j];
                }
            }
            Console.WriteLine("Произведение элементов строк без отрицательных элементов = " + prod);
        }
        static void Task11_2()
        {
            int n, m, i, j, columnswithzero, rownumber, maxlength, currentlength;
            Console.WriteLine("Задание 11.2");
            int[][] arr;
            bool containszero;
            Random rnd;
            Console.WriteLine("Введите высоту и ширину матрицы");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            arr = new int[n][];
            for (i = 0; i < n; i++)
                arr[i] = new int[m];
            rnd = new Random();
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    arr[i][j] = rnd.Next(-9, 10);
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }

            columnswithzero = 0;
            for (j = 0; j < m; j++)
            {
                containszero = false;
                for (i = 0; i < n; i++)
                    if (arr[i][j] == 0)
                        containszero = true;
                if (containszero)
                    columnswithzero++;
            }
            Console.WriteLine("Столбцов содержащих ноль = " + columnswithzero);

            rownumber = 0;
            maxlength = 1;
            for (i = 0; i < n; i++)
            {
                currentlength = 1;
                for (j = 1; j < m; j++)
                {
                    if (arr[i][j] == arr[i][j - 1])
                        currentlength++;
                    else
                        currentlength = 1;
                    if (currentlength > maxlength)
                    {
                        maxlength = currentlength;
                        rownumber = i;
                    }
                }
            }
            Console.WriteLine("Номер строки с самой длинной последовательностью одинаковых элементов = " + rownumber);
        }

        static void Main(string[] args)
        {
/* Task1_4();*/
            Task2_1();
            Task4_1();
            Task4_2();
            Task6_1();
            Task6_2();
            Task7_1();
            Task9_1();
            Task11_1();
            Task11_2();
        }
    }
}
