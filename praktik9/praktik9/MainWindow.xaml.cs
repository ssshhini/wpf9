using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Math_practice9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void cmbTasks_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            txtInput.Text = "";
            txtResult.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int selectedTask = cmbTasks.SelectedIndex;
            string input = txtInput.Text;
            string result = "";

            try
            {
                switch (selectedTask)
                {
                    case 0:
                        result = Task1(input);
                        break;
                    case 1:
                        result = Task2(input);
                        break;
                    case 2:
                        result = Task3(input);
                        break;
                    case 3:
                        result = Task4(input);
                        break;
                    case 4:
                        result = Task5(input);
                        break;
                    case 5:
                        result = Task6(input);
                        break;
                    case 6:
                        result = Task7(input);
                        break;
                    case 7:
                        result = Task8(input);
                        break;
                    case 8:
                        result = Task9(input);
                        break;
                    case 9:
                        result = Task10(input);
                        break;
                    case 10:
                        result = Task11(input);
                        break;
                    case 11:
                        result = Task12(input);
                        break;
                    case 12:
                        result = Task13(input);
                        break;
                    case 13:
                        result = Task14(input);
                        break;
                    case 14:
                        result = Task15(input);
                        break;
                    case 15:
                        result = Task16(input);
                        break;
                    case 16:
                        result = Task17(input);
                        break;
                    case 17:
                        result = Task18(input);
                        break;
                    case 18:
                        result = Task19(input);
                        break;
                    case 19:
                        result = Task20(input);
                        break;
                    case 20:
                        result = Task21(input);
                        break;
                    case 21:
                        result = Task22(input);
                        break;
                    case 22:
                        result = Task23(input);
                        break;
                    case 23:
                        result = Task24(input);
                        break;
                    case 24:
                        result = Task25(input);
                        break;
                    case 25:
                        result = Task26(input);
                        break;
                    case 26:
                        result = Task27(input);
                        break;
                    case 27:
                        result = Task28(input);
                        break;
                    case 28:
                        result = Task29(input);
                        break;
                    case 29:
                        result = Task30(input);
                        break;
                    default:
                        result = "Please select a task.";
                        break;
                }
            }
            catch (Exception ex)
            {
                result = "Error: " + ex.Message;
            }

            txtResult.Text = result;
        }

        private string Task1(string input)
        {
            string[] parts = input.Split(' ');
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            string result = "";
            int count = 0;

            for (int i = a; i <= b; i++)
            {
                result += i + " ";
                count++;
            }

            return $"Numbers between {a} and {b}:\n{result}\nTotal numbers: {count}";
        }

        private string Task2(string input)
        {
            string[] parts = input.Split(' ');
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            string result = "";
            int count = 0;

            for (int i = b - 1; i > a; i--)
            {
                result += i + " ";
                count++;
            }

            return $"Numbers between {a} and {b} (exclusive):\n{result}\nTotal numbers: {count}";
        }

        private string Task3(string input)
        {
            string[] parts = input.Split(' ');
            double a = double.Parse(parts[0]);
            int n = int.Parse(parts[1]);
            double result = Math.Pow(a, n);

            return $"{a}^{n} = {result}";
        }
        private string Task4(string input)
        {
            string[] parts = input.Split(' ');
            double a = double.Parse(parts[0]);
            int n = int.Parse(parts[1]);
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                result += $"{a}^{i} = {Math.Pow(a, i)}\n";
            }

            return $"Powers of {a} from 1 to {n}:\n{result}";
        }

        private string Task5(string input)
        {
            string[] parts = input.Split(' ');
            double a = double.Parse(parts[0]);
            int n = int.Parse(parts[1]);
            double sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(a, i);
            }

            return $"1 + {a} + {a}^2 + ... + {a}^{n} = {sum}";
        }

        private string Task6(string input)
        {
            string[] parts = input.Split(' ');
            int n = int.Parse(parts[0]);
            int k = 1;

            while (3 * k <= n)
            {
                k++;
            }

            return $"Smallest K where 3K > {n}: {k}, 3K = {3 * k}";
        }

        private string Task7(string input)
        {
            string[] parts = input.Split(' ');
            int n = int.Parse(parts[0]);
            int k = 1;

            while (3 * k < n)
            {
                k++;
            }

            k--;

            return $"Largest K where 3K < {n}: {k}, 3K = {3 * k}";
        }

        private string Task8(string input)
        {
            string[] parts = input.Split(' ');
            double a = double.Parse(parts[0]);
            int n = 1;
            double sum = 0;

            while (sum <= a)
            {
                sum += 1.0 / n;
                n++;
            }

            return $"Smallest N where sum 1 + 1/2 + ... + 1/N > {a}: {n - 1}, sum = {sum}";
        }

        private string Task9(string input)
        {
            string[] parts = input.Split(' ');
            int n = int.Parse(parts[0]);
            double product = 1;

            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }

            return $"Product 1*2*...*{n} = {product}";
        }

        private string Task10(string input)
        {
            string[] parts = input.Split(' ');
            int n = int.Parse(parts[0]);
            double product = 1;

            for (int i = 2; i <= n; i++)
            {
                product *= 1.0 / i;
            }

            return $"Product 1/2 * 1/3 * ... * 1/{n} = {product}";
        }

        private string Task11(string input)
        {
            string[] parts = input.Split(' ');
            double x = double.Parse(parts[0]);
            int n = int.Parse(parts[1]);
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(x, i) / i;
            }

            return $"1 + {x} + {x}^2/2 + ... + {x}^{n}/{n} = {sum}";
        }

        private string Task12(string input)
        {
            string[] parts = input.Split(' ');
            double x = double.Parse(parts[0]);
            int n = int.Parse(parts[1]);
            double sum = x;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);
            }

            return $"{x} - {x}^3/3 + {x}^5/5 - ... + (-1)^{n} {x}^{2 * n + 1}/{2 * n + 1} = {sum}";
        }

        private string Task13(string input)
        {
            string[] parts = input.Split(' ');
            double x = double.Parse(parts[0]);
            int n = int.Parse(parts[1]);
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1, i) * Math.Pow(x, 2 * i) / (2 * i);
            }

            return $"1 - {x}^2/2 + {x}^4/4 - ... + (-1)^{n} {x}^{2 * n}/{2 * n} = {sum}";
        }
        private string Task14(string input)
        {
            string[] parts = input.Split(' ');
            double x = double.Parse(parts[0]);
            int n = int.Parse(parts[1]);
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1, i - 1) * Math.Pow(x, i) / i;
            }

            return $"Sum: {sum}";
        }
        private string Task15(string input)
        {
            Console.WriteLine("Введите X (|X| < 1):");
            double X = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите N (> 0):");
            int N = int.Parse(Console.ReadLine());

            double result = 0;
            for (int i = 0; i <= N; i++)
            {
                result += Math.Pow(-1, i) * Math.Pow(X, 2 * i + 1) / (2 * i + 1);
            }

            return $"Result: {result}";
        }

        private string Task16(string input)
        {
            Console.WriteLine("Введите N (> 2):");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите A:");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B:");
            double B = double.Parse(Console.ReadLine());

            double H = (B - A) / (N - 1);
            Console.WriteLine($"H: {H}");

            double result = 0;
            for (int i = 0; i < N; i++)
            {
                result = A + i * H;
            }
            return $"Result: {result}";
        }

        private string Task17(string input)
        {
            Console.WriteLine("Введите N (> 2):");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите A:");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B:");
            double B = double.Parse(Console.ReadLine());

            double H = (B - A) / (N - 1);
            double result = 0;
            for (int i = 0; i < N; i++)
            {
                double X = A + i * H;
                result = X = 1 - Math.Sin(X);
            }
            return $"Result: {result}";
        }

        private string Task18(string input)
        {
            Console.WriteLine("Введите D (> 0):");
            double D = double.Parse(Console.ReadLine());

            double A1 = 2;
            double A2 = 2 + 1 / A1;
            int K = 2;

            while (Math.Abs(A2 - A1) >= D)
            {
                A1 = A2;
                A2 = 2 + 1 / A1;
                K++;
            }

            return $"Номер K: {K}, A{K - 1}: {A1}, A{K}: {A2}";
        }


        private string Task19(string input)
        {
            Console.WriteLine("Введите D (> 0):");
            double D = double.Parse(Console.ReadLine());

            double A1 = 1;
            double A2 = 2;
            double A3 = (A1 + A2) / 2;
            int K = 3;

            while (Math.Abs(A3 - A2) >= D)
            {
                A1 = A2;
                A2 = A3;
                A3 = (A1 + A2) / 2;
                K++;
            }

           return $"Номер K: {K}, A{K - 1}: {A2}, A{K}: {A3}";
        }

        private string Task20(string input)
        {
            Console.WriteLine("Введите N (> 10):");
            int N = int.Parse(Console.ReadLine());

            double result = 0;
            for (int i = 10; i <= N; i++)
            {
                if (i % 2 != 0 && i % 5 == 0)
                {
                    result = i;
                }
            }
            return $"Result: {result}";
        }

        private string Task21(string input)
        {
            double result = 0;
            for (int i = 11; i <= 99; i++)
            {
                result = i * i;
            }
            return $"Result: {result}";
        }

        private string Task22(string input)
        {
            double result = 0;
            while (true)
            {
                Console.WriteLine("Введите x (или 'exit' для завершения):");
                string input1 = Console.ReadLine();
                if (input1 == "exit") break;

                double x = double.Parse(input1);
                double r;

                if (x > 0 && x < 3.14)
                {
                    r = Math.Sin(x);
                }
                else if (x >= -3.14 && x < 0)
                {
                    r = Math.Pow(x, 3);
                }
                else if (x < -2 * 3.14 || x > 2 * 3.14)
                {
                    r = Math.Pow(x, 2);
                }
                else
                {
                    r = 0;
                }

                result = r;
            }
            return $"Result: {result}";
        }

        private string Task23(string input)
        {
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;
            long powerOfTwo = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                powerOfTwo *= 2;
            }

           return $"n!: {factorial}, 2^n: {powerOfTwo}";
        }

        private string Task24(string input)
        {
            Console.WriteLine("Введите N (> 10):");
            int N = int.Parse(Console.ReadLine());

            int maxDigit = 0;
            int number = N;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
                number /= 10;
            }

            return $"Наибольшая цифра: {maxDigit}";
        }

        private string Task25(string input)
        {
            Console.WriteLine("Введите N (> 10):");
            int N = int.Parse(Console.ReadLine());

            int number = N;
            int firstDigit = 0;
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                if (number == N)
                {
                    firstDigit = digit;
                }
                sum += digit;
                number /= 10;
            }

            return $"Первая цифра: {firstDigit}, Сумма цифр: {sum}";
        }

        private string Task26(string input)
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());

            string str = number.ToString();
            bool isPalindrome = true;

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome ? "Число является палиндромом." : "Число не является палиндромом.";
        }

        private string Task27(string input)
        {
            double result = 0;
            for (int i = 12; i <= 80; i++)
            {
                result = i * i;
            }
            return $"Result: {result}";
        }

        private string Task28(string input)
        {
            double result = 0;
            for (int i = 22; i <= 88; i++)
            {
                result = i * i - (i - 1) * (i - 1);
            }
            return $"Result: {result}";
        }

        private string Task29(string input)
        {
            Console.WriteLine("Введите A:");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите N (> 0):");
            int N = int.Parse(Console.ReadLine());

            double result = 0;
            for (int i = 1; i <= N; i++)
            {
               result = A * A - i * i;
            }
            return $"Result: {result}";
        }

        private string Task30(string input)
        {
            Console.WriteLine("Введите N (> 10):");
            int N = int.Parse(Console.ReadLine());

            int minDigit = 9;
            int number = N;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit < minDigit)
                {
                    minDigit = digit;
                }
                number /= 10;
            }

            return $"Наименьшая цифра: {minDigit}";
        }
    }
}


