using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Home2
{
    internal class Program
    {
        static void Random(int[,] Arr, int a)
        {
            Random r = new Random();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Arr[i, j] = r.Next(-a, a);
                }
            }
        }
        static void Print(int[] Arr)
        {
            foreach (var item in Arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
        static void Print(int[,] Arr)
        {
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write(Arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Search(int[] Arr)
        {
            int min = Arr[0], max = Arr[0], sum = 0, mult = 1, sumEven = 0;
            foreach (var item in Arr)
            {
                if (item < min)
                {
                    min = item;
                }
                if (item > max)
                {
                    max = item;
                }
                sum += item;
                mult *= item;
                if (item % 2 == 0)
                {
                    sumEven += item;
                }
            }
            Console.WriteLine($"Массив A\nМин: {min}\nМакс: {max}\nСумма всех элементов {sum}" +
                $"\nПроизведение всех элементов {mult}\nСумма четных элементов {sumEven} ");
        }
        static void Search(int[,] Arr)
        {
            int min = Arr[0, 0], max = Arr[0, 0], sum = 0, mult = 1, sumEven = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (!(j % 2 == 0))
                    {
                        sumEven += Arr[i, j];
                    }
                }
            }
            foreach (var i in Arr)
            {
                min = min < i ? min : i;
                max = max > i ? max : i;
                sum += i; mult *= i;
            }
            Console.WriteLine($"Массив B\nМин: {min}\nМакс: {max}\nСумма всех элементов {sum}" +
                $"\nПроизведение всех элементов {mult}\nСумма четных элементов {sumEven} ");
        }
        static void Main(string[] args)
        {
            /*int[] A = new int[5];
             for (int i = 0; i < A.Length; i++)
             {
                 A[i] = int.Parse(Console.ReadLine());
             }
             Console.Clear();
             int[,] B = new int[3, 4];
             Random(B,10);
             Print(A);
             Print(B);
             Search(A);
             Search(B);*/
            //Задание 2
            /*int[,] intArr = new int[5, 5];
            int minIndex_i = 0, minIndex_j=0;
            int maxIndex_i = 0, maxIndex_j=0;
            Random(intArr, 100);
            int sum = 0, min = intArr[0, 0], max = intArr[0, 0];
            for (int i = 0; i < intArr.GetLength(0); i++)
            {
            for (int j = 0; j < intArr.GetLength(1); j++)
            {
            if (min < intArr[i, j]) 
            {
                min = intArr[i, j]; minIndex_i = i; minIndex_j = j; 
            }
            if (max > intArr[i, j])
            {
                max = intArr[i, j]; maxIndex_i = i; maxIndex_j = j;
            }

            }
            }
            min = intArr[minIndex_i, minIndex_j];
            max = intArr[maxIndex_i, maxIndex_j];

            for (int i = 0; i < intArr.GetLength(0); i++)
            {
            for (int j = 0; j < intArr.GetLength(1); j++)
            {
            if (intArr[i, j] >= intArr[minIndex_i, maxIndex_j] || intArr[i, j] <= intArr[maxIndex_i, maxIndex_j])
            {
                sum += intArr[i, j];
            }

            }
            }

            Print(intArr);
            Console.WriteLine($"Сумма эле-ов между мин и макс {sum} {max} {min}");*/
            /*
            Console.Write("Введите арифметическое выражение: ");
            string input = Console.ReadLine();
            double result = Calculate(input);
            Console.WriteLine("Результат: " + result);*/
            /*
            // Создаём матрицы
            double[,] matrixA = { { 1, 2 }, { 3, 4 } };
            double[,] matrixB = { { 5, 6 }, { 7, 8 } };

            // Умножение матрицы на число
            double scalar = 2;
            double[,] result1 = MultiplyByScalar(matrixA, scalar);
            Console.WriteLine("Умножение матрицы на число:");
            PrintMatrix(result1);

            // Сложение матриц
            double[,] result2 = AddMatrices(matrixA, matrixB);
            Console.WriteLine("Сложение матриц:");
            PrintMatrix(result2);

            // Произведение матриц
            double[,] result3 = MultiplyMatrices(matrixA, matrixB);
            Console.WriteLine("Произведение матриц:");
            PrintMatrix(result3);*/
            /*
            Console.Write("Введите сообщение: ");
            string message = Console.ReadLine();
            Console.Write("Введите сдвиг: ");
            int shift = int.Parse(Console.ReadLine());

            // Зашифровать сообщение
            string encryptedMessage = Encrypt(message, shift);
            Console.WriteLine("Зашифрованное сообщение: " + encryptedMessage);

            // Расшифровать сообщение
            string decryptedMessage = Decrypt(encryptedMessage, shift);
            Console.WriteLine("Расшифрованное сообщение: " + decryptedMessage);
            */
            /*
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            // Изменить регистр первой буквы каждого предложения
            string result = CapitalizeSentences(text);
            Console.WriteLine("Результат: " + result);*/

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.Write("Введите запрещенные слова (через запятую): ");
            List<string> bannedWords = new List<string>(Console.ReadLine().Split(','));

            // Проверить текст на запрещенные слова
            string result = CensorText(text, bannedWords);
            Console.WriteLine("Результат: " + result);
        }
    
    static string CensorText(string text, List<string> bannedWords)
    {
        string[] words = text.Split(' ');
        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (bannedWords.Contains(words[i].ToLower()))
            {
                words[i] = new string('*', words[i].Length);
                count++;
            }
        }
        int percent = (int)(((double)count / words.Length) * 100);
        Console.WriteLine("Заменено слов: " + count + " (" + percent + "%)");
        return String.Join(" ", words);
    }
    static string CapitalizeSentences(string text)
    {
        string[] sentences = text.Split(new char[] { '.', '!', '?' });
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Trim().Length > 0)
            {
                char[] chars = sentences[i].ToCharArray();
                chars[0] = Char.ToUpper(chars[0]);
                sentences[i] = new string(chars);
            }
        }
        return String.Join("", sentences);
    }

    static string Encrypt(string message, int shift)
    {
        string result = "";
        foreach (char c in message)
        {
            if (Char.IsLetter(c))
            {
                char baseChar = Char.IsUpper(c) ? 'A' : 'a';
                char offsetChar = (char)(((c + shift) - baseChar) % 26 + baseChar);
                result += offsetChar;
            }
            else
            {
                result += c;
            }
        }
        return result;
    }

    static string Decrypt(string message, int shift)
    {
        return Encrypt(message, 26 - shift);
    }

    static double Calculate(string input)
    {
        Stack<double> operands = new Stack<double>();
        Stack<char> operators = new Stack<char>();
        foreach (char c in input)
        {
            if (Char.IsDigit(c))
            {
                operands.Push(double.Parse(c.ToString()));
            }
            else if (c == '+' || c == '-')
            {
                while (operators.Count > 0 && (operators.Peek() == '+' || operators.Peek() == '-'))
                {
                    char op = operators.Pop();
                    double b = operands.Pop();
                    double a = operands.Pop();
                    operands.Push(Execute(a, b, op));
                }
                operators.Push(c);
            }
            else
            {
                throw new ArgumentException("Invalid character: " + c);
            }
        }
        while (operators.Count > 0)
        {
            char op = operators.Pop();
            double b = operands.Pop();
            double a = operands.Pop();
            operands.Push(Execute(a, b, op));
        }
        return operands.Pop();
    }
    static double Execute(double a, double b, char op)
    {
        if (op == '+')
        {
            return a + b;
        }
        else if (op == '-')
        {
            return a - b;
        }
        else
        {
            throw new ArgumentException("Invalid operator: " + op);
        }
    }
    // Умножение матрицы на число
    static double[,] MultiplyByScalar(double[,] matrix, double scalar)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);
        double[,] result = new double[rowCount, colCount];
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        return result;
    }

    // Сложение матриц
    static double[,] AddMatrices(double[,] matrixA, double[,] matrixB)
    {
        int rowCount = matrixA.GetLength(0);
        int colCount = matrixA.GetLength(1);
        double[,] result = new double[rowCount, colCount];
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }
        return result;
    }

    // Произведение матриц
    static double[,] MultiplyMatrices(double[,] matrixA, double[,] matrixB)
    {
        int rowCountA = matrixA.GetLength(0);
        int colCountA = matrixA.GetLength(1);
        int rowCountB = matrixB.GetLength(0);
        int colCountB = matrixB.GetLength(1);
        if (colCountA != rowCountB)
        {
            throw new ArgumentException("Invalid matrix dimensions.");
        }
        double[,] result = new double[rowCountA, colCountB];
        for (int i = 0; i < rowCountA; i++)
        {
            for (int j = 0; j < colCountB; j++)
            {
                double sum = 0;
                for (int k = 0; k < colCountA; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }

    // Вывод матрицы в консоль
    static void PrintMatrix(double[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    }
}
  
    

