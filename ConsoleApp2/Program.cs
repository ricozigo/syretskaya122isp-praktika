//Задание 1 калькулятор +

//using System;


//{
//    double a, b;
//    string action;

//    Console.WriteLine("Введите число 1");
//    a = double.Parse(Console.ReadLine());


//    Console.WriteLine("Введите число 2");
//    b = double.Parse(Console.ReadLine());

//    Console.WriteLine("Выберите операции:'+' '-' '*' '/'");
//    action = Console.ReadLine();



//    if (action == "+")
//    {
//        Console.WriteLine(a + b);
//    }
//    else if (action == "-")
//    {
//        Console.WriteLine(a - b);
//    }
//    else if (action == "*")
//    {
//        Console.WriteLine(a * b);
//    }
//    else if (action == "/")
//    {
//        Console.WriteLine(a / b);
//    }

//}









// 2-ое Обработка строк

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите строку:");
//        string input = Console.ReadLine();

//        // Подсчет символов
//        int characterCount = input.Length;

//        // Подсчет слов
//        string[] words = input.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
//        int wordCount = words.Length;

//        // Подсчет предложений
//        char[] sentenceDelimiters = { '.', '!', '?' };
//        string[] sentences = input.Split(sentenceDelimiters, StringSplitOptions.RemoveEmptyEntries);
//        int sentenceCount = sentences.Length;

//        // Вывод результатов
//        Console.WriteLine($"Количество символов: {characterCount}");
//        Console.WriteLine($"Количество слов: {wordCount}");
//        Console.WriteLine($"Количество предложений: {sentenceCount}");
//    }
//}












//задание 3 таблица умножений

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Таблица умножения от 1 до 10:");

//        // Внешний цикл для чисел от 1 до 10
//        for (int i = 1; i <= 10; i++)
//        {
//            // Внутренний цикл для умножения
//            for (int j = 1; j <= 10; j++)
//            {
//                // Вывод результата умножения
//                Console.Write($"{i * j,4} "); 
//            }
//            Console.WriteLine(); 
//        }
//    }
//}











//задание 4 Факториал числа

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число для вычисления факториала: ");
//        int number;

//        // Проверяем, является ли введенное значение числом
//        if (int.TryParse(Console.ReadLine(), out number) && number >= 0)
//        {
//            long factorial = CalculateFactorial(number);
//            Console.WriteLine($"Факториал числа {number} равен {factorial}");
//        }
//        else
//        {
//            Console.WriteLine("Пожалуйста, введите неотрицательное целое число.");
//        }
//    }

//    // Метод для вычисления факториала
//    static long CalculateFactorial(int n)
//    {
//        long result = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            result *= i;
//        }
//        return result;
//    }
//}









//задание 5 Числа фибоначчи

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите количество чисел Фибоначчи для вывода: ");
//        int n;

//        // Проверяем, является ли введенное значение числом
//        if (int.TryParse(Console.ReadLine(), out n) && n > 0)
//        {
//            Console.WriteLine($"Первые {n} чисел ряда Фибоначчи:");
//            PrintFibonacci(n);
//        }
//        else
//        {
//            Console.WriteLine("Пожалуйста, введите положительное целое число.");
//        }
//    }

//    // Метод для вывода первых n чисел Фибоначчи
//    static void PrintFibonacci(int n)
//    {
//        long a = 0, b = 1;

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write(a + " ");
//            long next = a + b;
//            a = b;
//            b = next;
//        }

//        Console.WriteLine(); // Переход на новую строку после вывода
//    }
//}












//задание 6 поиск простых чисел

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число n: ");
//        int n;

//        if (int.TryParse(Console.ReadLine(), out n) && n > 1)
//        {
//            Console.WriteLine($"Простые числа от 1 до {n}:");
//            PrintPrimeNumbers(n);
//        }
//        else
//        {
//            Console.WriteLine("Пожалуйста, введите целое число больше 1.");
//        }
//    }

//    static bool IsPrime(int number)
//    {
//        if (number < 2) return false;
//        for (int i = 2; i <= Math.Sqrt(number); i++)
//        {
//            if (number % i == 0) return false;
//        }
//        return true;
//    }

//    static void PrintPrimeNumbers(int n)
//    {
//        for (int i = 2; i <= n; i++)
//        {
//            if (IsPrime(i))
//            {
//                Console.Write(i + " ");
//            }
//        }

//        Console.WriteLine(); // Переход на новую строку после вывода
//    }
//}













//задание 7 игра угадай число

/*using System;

class GuessTheNumberGame
{
    static void Main()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101); 
        int userGuess = 0;
        int attempts = 0;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать его.");

        while (userGuess != targetNumber)
        {
            Console.Write("Введите ваше предположение: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userGuess))
            {
                attempts++;

                if (userGuess < 1 || userGuess > 100)
                {
                    Console.WriteLine("Пожалуйста, введите число в диапазоне от 1 до 100.");
                }
                else if (userGuess < targetNumber)
                {
                    Console.WriteLine("Слишком низко! Попробуйте снова.");
                }
                else if (userGuess > targetNumber)
                {
                    Console.WriteLine("Слишком высоко! Попробуйте снова.");
                }
                else
                {
                    Console.WriteLine($"Поздравляю! Вы угадали число {targetNumber} за {attempts} попыток.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }
    }
}*/








//задание 8

/*using System;

class AreaCalculator
{
    static void Main()
    {
        Console.WriteLine("Выберите фигуру для вычисления площади:");
        Console.WriteLine("1. Круг");
        Console.WriteLine("2. Треугольник");
        Console.WriteLine("3. Прямоугольник");
        Console.Write("Введите номер фигуры (1-3): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CalculateCircleArea();
                break;
            case "2":
                CalculateTriangleArea();
                break;
            case "3":
                CalculateRectangleArea();
                break;
            default:
                Console.WriteLine("Некорректный выбор. Пожалуйста, введите номер от 1 до 3.");
                break;
        }
    }

    static void CalculateCircleArea()
    {
        Console.Write("Введите радиус круга: ");
        if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь круга: {area:F2}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное число.");
        }
    }

    static void CalculateTriangleArea()
    {
        Console.Write("Введите основание треугольника: ");
        if (double.TryParse(Console.ReadLine(), out double baseLength) && baseLength > 0)
        {
            Console.Write("Введите высоту треугольника: ");
            if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
            {
                double area = 0.5 * baseLength * height;
                Console.WriteLine($"Площадь треугольника: {area:F2}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод высоты. Пожалуйста, введите положительное число.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод основания. Пожалуйста, введите положительное число.");
        }
    }

    static void CalculateRectangleArea()
    {
        Console.Write("Введите длину прямоугольника: ");
        if (double.TryParse(Console.ReadLine(), out double length) && length > 0)
        {
            Console.Write("Введите ширину прямоугольника: ");
            if (double.TryParse(Console.ReadLine(), out double width) && width > 0)
            {
                double area = length * width;
                Console.WriteLine($"Площадь прямоугольника: {area:F2}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод ширины. Пожалуйста, введите положительное число.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод длины. Пожалуйста, введите положительное число.");
        }
    }
}

*/













/*Задание 9*/

//using System;

//class UnitConverter
//{
//    static void Main()
//    {
//        Console.WriteLine("Выберите тип перевода:");
//        Console.WriteLine("1. Метры в километры");
//        Console.WriteLine("2. Килограммы в граммы");
//        Console.WriteLine("3. Литры в миллилитры");
//        Console.WriteLine("4. Цельсия в Фаренгейты");
//        Console.Write("Введите номер перевода (1-4): ");

//        string choice = Console.ReadLine();

//        switch (choice)
//        {
//            case "1":
//                ConvertMetersToKilometers();
//                break;
//            case "2":
//                ConvertKilogramsToGrams();
//                break;
//            case "3":
//                ConvertLitersToMilliliters();
//                break;
//            case "4":
//                ConvertCelsiusToFahrenheit();
//                break;
//            default:
//                Console.WriteLine("Некорректный выбор. Пожалуйста, введите номер от 1 до 4.");
//                break;
//        }
//    }

//    static void ConvertMetersToKilometers()
//    {
//        Console.Write("Введите метры: ");
//        if (double.TryParse(Console.ReadLine(), out double meters))
//        {
//            double kilometers = meters / 1000;
//            Console.WriteLine($"{meters} метров = {kilometers:F2} километров");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
//        }
//    }

//    static void ConvertKilogramsToGrams()
//    {
//        Console.Write("Введите килограммы: ");
//        if (double.TryParse(Console.ReadLine(), out double kilograms))
//        {
//            double grams = kilograms * 1000;
//            Console.WriteLine($"{kilograms} килограммов = {grams:F2} граммов");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
//        }
//    }

//    static void ConvertLitersToMilliliters()
//    {
//        Console.Write("Введите литры: ");
//        if (double.TryParse(Console.ReadLine(), out double liters))
//        {
//            double milliliters = liters * 1000;
//            Console.WriteLine($"{liters} литров = {milliliters:F2} миллилитров");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
//        }
//    }

//    static void ConvertCelsiusToFahrenheit()
//    {
//        Console.Write("Введите температуру в градусах Цельсия: ");
//        if (double.TryParse(Console.ReadLine(), out double celsius))
//        {
//            double fahrenheit = (celsius * 9 / 5) + 32;
//            Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
//        }
//    }
//}












/*задание 10*/

/*using System;

class PercentageCalculator
{
    static void Main()
    {
        Console.WriteLine("Программа для вычисления процента от числа.");

        // Ввод числа
        Console.Write("Введите число: ");
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            // Ввод процента
            Console.Write("Введите процент: ");
            if (double.TryParse(Console.ReadLine(), out double percentage))
            {
                // Вычисление процента
                double result = (percentage / 100) * number;
                Console.WriteLine($"{percentage}% от {number} = {result}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод процента. Пожалуйста, введите число.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод числа. Пожалуйста, введите число.");
        }
    }
}*/













/*задание 11  */

/*using System;

class CurrencyConverter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите валюту для конвертации:");
        Console.WriteLine("1. Доллары (USD)");
        Console.WriteLine("2. Евро (EUR)");
        Console.Write("Введите номер валюты (1 или 2): ");
        int currencyChoice = Convert.ToInt32(Console.ReadLine());

        double exchangeRate;

        if (currencyChoice == 1)
        {
            Console.Write("Введите курс USD к RUB: ");
            exchangeRate = Convert.ToDouble(Console.ReadLine());
        }
        else if (currencyChoice == 2)
        {
            Console.Write("Введите курс EUR к RUB: ");
            exchangeRate = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Неверный выбор. Завершение программы.");
            return;
        }

        Console.Write($"Введите сумму в {(currencyChoice == 1 ? "USD" : "EUR")} для конвертации: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        double amountInRUB = amount * exchangeRate;

        Console.WriteLine($"{amount} {(currencyChoice == 1 ? "USD" : "EUR")} = {amountInRUB} RUB по курсу {exchangeRate}");
    }
}*/








/*задание 12*/

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 12, 5, 8, 21, 3, 17, 9 };

//        if (numbers.Length == 0)
//        {
//            Console.WriteLine("Массив пуст.");
//            return;
//        }

//        int minValue = numbers[0];
//        int maxValue = numbers[0];
//        int minIndex = 0;
//        int maxIndex = 0;

//        for (int i = 1; i < numbers.Length; i++)
//        {
//            if (numbers[i] < minValue)
//            {
//                minValue = numbers[i];
//                minIndex = i;
//            }
//            if (numbers[i] > maxValue)
//            {
//                maxValue = numbers[i];
//                maxIndex = i;
//            }
//        }

//        Console.WriteLine($"Минимальный элемент: {minValue}, индекс: {minIndex}");
//        Console.WriteLine($"Максимальный элемент: {maxValue}, индекс: {maxIndex}");

//        Console.WriteLine("Нажмите любую клавишу для выхода...");
//        Console.ReadKey();
//    }
//}













/*задание 13*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        BubbleSortAscending(array);
        Console.WriteLine("\nОтсортированный массив по возрастанию:");
        PrintArray(array);

        int[] arrayForDescending = { 64, 34, 25, 12, 22, 11, 90 };
        SelectionSortDescending(arrayForDescending);
        Console.WriteLine("\nОтсортированный массив по убыванию:");
        PrintArray(arrayForDescending);
    }

    static void BubbleSortAscending(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Меняем arr[j] и arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void SelectionSortDescending(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] > arr[maxIndex])
                {
                    maxIndex = j;
                }
            }

            int temp = arr[maxIndex];
            arr[maxIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}*/












/*зАДАНИЕ 14*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

        Console.WriteLine("Введите элемент для поиска:");
        int searchElement;

        while (!int.TryParse(Console.ReadLine(), out searchElement))
        {
            Console.WriteLine("Пожалуйста, введите корректное целое число.");
        }

        int index = FindElementIndex(array, searchElement);

        if (index != -1)
        {
            Console.WriteLine($"Элемент {searchElement} найден на индексе {index}.");
        }
        else
        {
            Console.WriteLine($"Элемент {searchElement} не найден в массиве.");
        }
    }

    static int FindElementIndex(int[] arr, int element)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == element)
            {
                return i; 
            }
        }
        return -1; // Возвращаем -1, если элемент не найден
    }
}
*/












/*Задание 15*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Вывод элементов массива в обратном порядке
        Console.WriteLine("Элементы массива в обратном порядке:");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine(); 
    }
}*/












/*задание 16  *//* 
using System;

class MatrixOperations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите размеры матриц (строки и столбцы):");
        Console.Write("Количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Количество столбцов: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите элементы первой матрицы:");
        double[,] matrixA = ReadMatrix(rows, cols);

        Console.WriteLine("Введите элементы второй матрицы:");
        double[,] matrixB = ReadMatrix(rows, cols);

        Console.WriteLine("Сложение матриц:");
        PrintMatrix(AddMatrices(matrixA, matrixB));

        Console.WriteLine("Вычитание матриц:");
        PrintMatrix(SubtractMatrices(matrixA, matrixB));

        Console.WriteLine("Умножение матриц:");
        PrintMatrix(MultiplyMatrices(matrixA, matrixB));

        Console.WriteLine("Транспонирование первой матрицы:");
        PrintMatrix(TransposeMatrix(matrixA));
    }

    static double[,] ReadMatrix(int rows, int cols)
    {
        double[,] matrix = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Введите элементы строки {i + 1} (через пробел):");
            string[] elements = Console.ReadLine().Split(' ');
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Convert.ToDouble(elements[j]);
            }
        }
        return matrix;
    }

    static double[,] AddMatrices(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = a[i, j] + b[i, j];
        return result;
    }

    static double[,] SubtractMatrices(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = a[i, j] - b[i, j];
        return result;
    }

    static double[,] MultiplyMatrices(double[,] a, double[,] b)
    {
        int rowsA = a.GetLength(0);
        int colsA = a.GetLength(1);
        int colsB = b.GetLength(1);
        double[,] result = new double[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
            for (int j = 0; j < colsB; j++)
                for (int k = 0; k < colsA; k++)
                    result[i, j] += a[i, k] * b[k, j];

        return result;
    }

    static double[,] TransposeMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[cols, rows];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[j, i] = matrix[i, j];

        return result;
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }
}









/*задание 17*/

//using System;

//class NumberConverter
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число в десятичной системе: ");
//        int decimalNumber;

//        // Проверяем, является ли ввод целым числом
//        while (!int.TryParse(Console.ReadLine(), out decimalNumber))
//        {
//            Console.WriteLine("Пожалуйста, введите корректное целое число: ");
//        }

//        // Переводим в другие системы счисления
//        string binary = Convert.ToString(decimalNumber, 2);
//        string octal = Convert.ToString(decimalNumber, 8);
//        string hexadecimal = Convert.ToString(decimalNumber, 16).ToUpper();

//        // Выводим результаты
//        Console.WriteLine($"\nДесятичное число: {decimalNumber}");
//        Console.WriteLine($"Двоичное представление: {binary}");
//        Console.WriteLine($"Восьмеричное представление: {octal}");
//        Console.WriteLine($"Шестнадцатеричное представление: {hexadecimal}");
//    }
//}











/*задание 18*/
//using System;

//class NumberPyramid
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите высоту пирамиды: ");
//        int height;

//        // Проверяем, является ли ввод целым числом
//        while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
//        {
//            Console.WriteLine("Пожалуйста, введите корректное положительное целое число: ");
//        }

//        // Генерируем пирамиду
//        for (int i = 1; i <= height; i++)
//        {
//            // Вывод пробелов для центрирования
//            Console.Write(new string(' ', height - i));

//            // Вывод чисел
//            for (int j = 1; j <= i; j++)
//            {
//                Console.Write(j + " ");
//            }

//            // Переход на новую строку
//            Console.WriteLine();
//        }
//    }
//}














/*задание 19*/
//using System;

//class SubstringSearch
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку: ");
//        string mainString = Console.ReadLine();

//        Console.WriteLine("Введите подстроку для поиска: ");
//        string substring = Console.ReadLine();

//        // Ищем индекс подстроки
//        int index = mainString.IndexOf(substring);

//        // Проверяем, найден ли индекс
//        if (index != -1)
//        {
//            Console.WriteLine($"Подстрока найдена на индексе: {index}");
//        }
//        else
//        {
//            Console.WriteLine("Подстрока не найдена.");
//        }
//    }
//}








/*задание 20  */
/*using System;

class RemoveExtraSpaces
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку с лишними пробелами:");
        string input = Console.ReadLine();

        string result = RemoveExtraSpacesFromString(input);

        Console.WriteLine("Строка без лишних пробелов:");
        Console.WriteLine(result);
    }

    static string RemoveExtraSpacesFromString(string input)
    {
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return string.Join(" ", words);
    }
}*/














/*Задание 21*/
//using System;

//class DaysBetweenDates
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите первую дату (в формате ГГГГ-ММ-ДД): ");
//        string firstDateInput = Console.ReadLine();

//        Console.WriteLine("Введите вторую дату (в формате ГГГГ-ММ-ДД): ");
//        string secondDateInput = Console.ReadLine();

//        try
//        {
//            DateTime firstDate = DateTime.Parse(firstDateInput);
//            DateTime secondDate = DateTime.Parse(secondDateInput);

//            // Вычисляем количество дней между датами
//            TimeSpan difference = secondDate - firstDate;
//            int daysDifference = Math.Abs(difference.Days);

//            Console.WriteLine($"Количество дней между {firstDate.ToShortDateString()} и {secondDate.ToShortDateString()} составляет {daysDifference} дней.");
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Ошибка: Введены неверные даты. Пожалуйста, используйте формат ГГГГ-ММ-ДД.");
//        }
//    }
//}








/*Задание 22*/
//using System;
//using System.Text.RegularExpressions;

//class InputValidation
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите номер телефона (формат: +7 (999) 999-99-99):");
//        string phoneInput = Console.ReadLine();

//        if (IsValidPhoneNumber(phoneInput))
//        {
//            Console.WriteLine("Номер телефона введен корректно.");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный номер телефона.");
//        }

//        Console.WriteLine("\nВведите адрес электронной почты:");
//        string emailInput = Console.ReadLine();

//        if (IsValidEmail(emailInput))
//        {
//            Console.WriteLine("Адрес электронной почты введен корректно.");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный адрес электронной почты.");
//        }
//    }

//    static bool IsValidPhoneNumber(string phone)
//    {
//        string pattern = @"^\+7 \(\d{3}\) \d{3}-\d{2}-\d{2}$";
//        return Regex.IsMatch(phone, pattern);
//    }

//    static bool IsValidEmail(string email)
//    {
//        // Регулярное выражение для проверки адреса электронной почты
//        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//        return Regex.IsMatch(email, pattern);
//    }
//}






















/*задание 23 */
/*using System;
using System.Text;

class RandomPasswordGenerator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите желаемую длину пароля:");
        int length;

        while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
        {
            Console.WriteLine("Пожалуйста, введите положительное целое число.");
        }

        string password = GenerateRandomPassword(length);
        Console.WriteLine($"Сгенерированный пароль: {password}");
    }

    static string GenerateRandomPassword(int length)
    {
        const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        const string digits = "0123456789";
        const string specialChars = "!@#$%^&*()-_=+[]{};:,.<>?";

        string allChars = upperCase + lowerCase + digits + specialChars;
        StringBuilder password = new StringBuilder();

        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(allChars.Length);
            password.Append(allChars[index]);
        }

        return password.ToString();
    }
}*/






/*Задание 24*/

/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        const double vatRate = 0.20;

        Список для хранения покупок
        List<Item> items = new List<Item>();

        Ввод данных
        Console.WriteLine("Введите список покупок и их стоимость. Введите 'end' для завершения.");

        while (true)
        {
            Console.Write("Введите наименование товара (или 'end' для завершения): ");
            string name = Console.ReadLine();
            if (name.ToLower() == "end") break;

            double price;
            while (true)
            {
                Console.Write($"Введите стоимость товара '{name}': ");
                if (double.TryParse(Console.ReadLine(), out price) && price >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите корректное значение для стоимости.");
                }
            }

            items.Add(new Item(name, price));
        }

        Расчеты
        double totalSum = 0;
        foreach (var item in items)
        {
            totalSum += item.Price;
        }

        double vatAmount = totalSum * vatRate;
        double totalWithVat = totalSum + vatAmount;

        Вывод чека
        Console.WriteLine("\n--- Чек ---");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name}: {item.Price:C}");
        }
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Общая сумма: {totalSum:C}");
        Console.WriteLine($"НДС (20%): {vatAmount:C}");
        Console.WriteLine($"Итоговая сумма с НДС: {totalWithVat:C}");
    }
}

class Item
{
    public string Name { get; }
    public double Price { get; }

    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }
}*/









/*задание 25*/
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите текст для анализа:");
//        string input = Console.ReadLine();

//        var wordFrequency = AnalyzeText(input);

//        Console.WriteLine("\nСтатистика по частоте использования слов:");
//        foreach (var entry in wordFrequency.OrderByDescending(e => e.Value))
//        {
//            Console.WriteLine($"{entry.Key}: {entry.Value}");
//        }
//    }

//    static Dictionary<string, int> AnalyzeText(string text)
//    {
//        var words = text.ToLower()
//                        .Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' },
//                               StringSplitOptions.RemoveEmptyEntries);

//        var wordCount = new Dictionary<string, int>();

//        foreach (var word in words)
//        {
//            if (wordCount.ContainsKey(word))
//            {
//                wordCount[word]++;
//            }
//            else
//            {
//                wordCount[word] = 1;
//            }
//        }

//        return wordCount;
//    }
//}







/*задание 26*/
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите первое время:");
//        TimeSpan time1 = GetTimeFromUser();

//        Console.WriteLine("Введите второе время:");
//        TimeSpan time2 = GetTimeFromUser();

//        Console.WriteLine("Выберите операцию (сложение или вычитание):");
//        Console.WriteLine("1. Сложение");
//        Console.WriteLine("2. Вычитание");

//        string choice = Console.ReadLine();
//        TimeSpan result;

//        switch (choice)
//        {
//            case "1":
//                result = time1 + time2;
//                break;
//            case "2":
//                result = time1 - time2;
//                break;
//            default:
//                Console.WriteLine("Некорректный выбор. Операция не выполнена.");
//                return;
//        }

//        Console.WriteLine($"Результат: {FormatTimeSpan(result)}");
//    }

//    static TimeSpan GetTimeFromUser()
//    {
//        int hours, minutes;

//        while (true)
//        {
//            Console.Write("Введите часы: ");
//            if (int.TryParse(Console.ReadLine(), out hours) && hours >= 0)
//            {
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Введите корректное значение для часов.");
//            }
//        }

//        while (true)
//        {
//            Console.Write("Введите минуты: ");
//            if (int.TryParse(Console.ReadLine(), out minutes) && minutes >= 0 && minutes < 60)
//            {
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Введите корректное значение для минут (0-59).");
//            }
//        }

//        return new TimeSpan(hours, minutes, 0);
//    }

//    static string FormatTimeSpan(TimeSpan timeSpan)
//    {
//        // Форматируем результат так, чтобы он показывал часы и минуты
//        int hours = (int)timeSpan.TotalHours;
//        int minutes = timeSpan.Minutes;

//        // Если результат отрицательный, то устанавливаем отрицательный знак
//        if (timeSpan.TotalHours < 0)
//        {
//            return $"-{Math.Abs(hours)}:{Math.Abs(minutes):D2}";
//        }
//        return $"{hours}:{minutes:D2}";
//    }
//}










/*задание 27*/
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите коэффициенты квадратного уравнения ax^2 + bx + c = 0");

//        // Ввод коэффициентов
//        double a = GetCoefficient("a");
//        double b = GetCoefficient("b");
//        double c = GetCoefficient("c");

//        // Вычисление дискриминанта
//        double discriminant = b * b - 4 * a * c;

//        // Нахождение корней уравнения
//        if (discriminant > 0)
//        {
//            // Два различных корня
//            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
//            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
//            Console.WriteLine($"Уравнение имеет два корня: x1 = {x1} и x2 = {x2}");
//        }
//        else if (discriminant == 0)
//        {
//            // Один корень
//            double x = -b / (2 * a);
//            Console.WriteLine($"Уравнение имеет один корень: x = {x}");
//        }
//        else
//        {
//            // Нет вещественных корней
//            Console.WriteLine("Уравнение не имеет вещественных корней.");
//        }
//    }

//    static double GetCoefficient(string coefficientName)
//    {
//        double coefficient;
//        while (true)
//        {
//            Console.Write($"Введите коэффициент {coefficientName}: ");
//            if (double.TryParse(Console.ReadLine(), out coefficient))
//            {
//                return coefficient;
//            }
//            else
//            {
//                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
//            }
//        }
//    }
//}











//задание 28
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите коэффициенты системы линейных уравнений:");
//        Console.WriteLine("a1 * x + b1 * y = c1");
//        Console.WriteLine("a2 * x + b2 * y = c2");

//        // Ввод коэффициентов
//        double a1 = GetCoefficient("a1");
//        double b1 = GetCoefficient("b1");
//        double c1 = GetCoefficient("c1");
//        double a2 = GetCoefficient("a2");
//        double b2 = GetCoefficient("b2");
//        double c2 = GetCoefficient("c2");

//        // Вычисление детерминантов
//        double D = a1 * b2 - a2 * b1;
//        double Dx = c1 * b2 - c2 * b1;
//        double Dy = a1 * c2 - a2 * c1;

//        if (D == 0)
//        {
//            if (Dx == 0 && Dy == 0)
//            {
//                Console.WriteLine("Система имеет бесконечно много решений.");
//            }
//            else
//            {
//                Console.WriteLine("Система не имеет решений.");
//            }
//        }
//        else
//        {
//            // Вычисление решений
//            double x = Dx / D;
//            double y = Dy / D;
//            Console.WriteLine($"Решение системы: x = {x}, y = {y}");
//        }
//    }

//    static double GetCoefficient(string coefficientName)
//    {
//        double coefficient;
//        while (true)
//        {
//            Console.Write($"Введите коэффициент {coefficientName}: ");
//            if (double.TryParse(Console.ReadLine(), out coefficient))
//            {
//                return coefficient;
//            }
//            else
//            {
//                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
//            }
//        }
//    }
//}













/*задание 29*/
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Информация о доступных дисках на компьютере:");

//        // Получаем все доступные диски
//        DriveInfo[] drives = DriveInfo.GetDrives();

//        foreach (DriveInfo drive in drives)
//        {
//            // Проверяем, доступен ли диск
//            if (drive.IsReady)
//            {
//                Console.WriteLine($"Диск: {drive.Name}");
//                Console.WriteLine($"  Файловая система: {drive.DriveFormat}");
//                Console.WriteLine($"  Метка тома: {drive.VolumeLabel}");
//                Console.WriteLine($"  Размер: {FormatBytes(drive.TotalSize)}");
//                Console.WriteLine($"  Свободное место: {FormatBytes(drive.AvailableFreeSpace)}");
//                Console.WriteLine($"  Использовано: {FormatBytes(drive.TotalSize - drive.AvailableFreeSpace)}");
//                Console.WriteLine();
//            }
//            else
//            {
//                Console.WriteLine($"Диск: {drive.Name} недоступен.");
//                Console.WriteLine();
//            }
//        }
//    }

//    static string FormatBytes(long bytes)
//    {
//        if (bytes >= 1L << 40)
//            return $"{bytes >> 40} TB";
//        if (bytes >= 1L << 30)
//            return $"{bytes >> 30} GB";
//        if (bytes >= 1L << 20)
//            return $"{bytes >> 20} MB";
//        if (bytes >= 1L << 10)
//            return $"{bytes >> 10} KB";
//        return $"{bytes} bytes";
//    }
//}










/*Задание 30*/
//using System;
//using System.IO;

//class FileManager
//{
//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.WriteLine("Выберите операцию:");
//            Console.WriteLine("1. Создать файл");
//            Console.WriteLine("2. Удалить файл");
//            Console.WriteLine("3. Копировать файл");
//            Console.WriteLine("4. Переместить файл");
//            Console.WriteLine("5. Выход");
//            Console.Write("Введите номер операции: ");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    CreateFile();
//                    break;
//                case "2":
//                    DeleteFile();
//                    break;
//                case "3":
//                    CopyFile();
//                    break;
//                case "4":
//                    MoveFile();
//                    break;
//                case "5":
//                    return;
//                default:
//                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
//                    break;
//            }
//        }
//    }

//    static void CreateFile()
//    {
//        Console.Write("Введите имя файла для создания: ");
//        string fileName = Console.ReadLine();
//        File.Create(fileName).Close();
//        Console.WriteLine($"Файл '{fileName}' создан.");
//    }

//    static void DeleteFile()
//    {
//        Console.Write("Введите имя файла для удаления: ");
//        string fileName = Console.ReadLine();
//        if (File.Exists(fileName))
//        {
//            File.Delete(fileName);
//            Console.WriteLine($"Файл '{fileName}' удален.");
//        }
//        else
//        {
//            Console.WriteLine($"Файл '{fileName}' не найден.");
//        }
//    }

//    static void CopyFile()
//    {
//        Console.Write("Введите имя файла для копирования: ");
//        string sourceFile = Console.ReadLine();
//        Console.Write("Введите имя для копии: ");
//        string destFile = Console.ReadLine();

//        if (File.Exists(sourceFile))
//        {
//            File.Copy(sourceFile, destFile);
//            Console.WriteLine($"Файл '{sourceFile}' скопирован в '{destFile}'.");
//        }
//        else
//        {
//            Console.WriteLine($"Файл '{sourceFile}' не найден.");
//        }
//    }

//    static void MoveFile()
//    {
//        Console.Write("Введите имя файла для перемещения: ");
//        string sourceFile = Console.ReadLine();
//        Console.Write("Введите путь для перемещения файла (включая имя файла): ");
//        string destFile = Console.ReadLine();

//        if (File.Exists(sourceFile))
//        {
//            File.Move(sourceFile, destFile);
//            Console.WriteLine($"Файл '{sourceFile}' перемещен в '{destFile}'.");
//        }
//        else
//        {
//            Console.WriteLine($"Файл '{sourceFile}' не найден.");
//        }
//    }
//}







/*Задание 31*/
//using System;
//using System.Collections.Generic;
//using System.IO;
//using Newtonsoft.Json;

//class Program
//{
//    public class Person
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }

//    static void Main(string[] args)
//    {
//        string jsonFilePath = "data.json";

//        if (File.Exists(jsonFilePath))
//        {
//            string jsonData = File.ReadAllText(jsonFilePath);
//            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(jsonData);

//            Console.WriteLine("ID\tИмя\tВозраст");
//            Console.WriteLine("-------------------------");

//            foreach (var person in people)
//            {
//                Console.WriteLine($"{person.Id}\t{person.Name}\t{person.Age}");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Файл не найден.");
//        }
//    }
//}








/*Задание 32*/
//using System;
//using System.Collections.Generic;
//using System.Xml.Linq;

//class Program
//{
//    public class Person
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }

//    static void Main(string[] args)
//    {
//        string xmlFilePath = "data.xml";

//        if (System.IO.File.Exists(xmlFilePath))
//        {
//            XDocument xdoc = XDocument.Load(xmlFilePath);
//            List<Person> people = new List<Person>();

//            foreach (var element in xdoc.Descendants("Person"))
//            {
//                Person person = new Person
//                {
//                    Id = (int)element.Element("Id"),
//                    Name = (string)element.Element("Name"),
//                    Age = (int)element.Element("Age")
//                };
//                people.Add(person);
//            }

//            Console.WriteLine("ID\tИмя\tВозраст");
//            Console.WriteLine("-------------------------");

//            foreach (var person in people)
//            {
//                Console.WriteLine($"{person.Id}\t{person.Name}\t{person.Age}");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Файл не найден.");
//        }
//    }
//}










/*Задание 33*/
//using System;
//using System.Collections.Generic;

//class Program
//{
//    public class Task
//    {
//        public string Name { get; set; }
//        public bool IsCompleted { get; set; }

//        public Task(string name)
//        {
//            Name = name;
//            IsCompleted = false;
//        }

//        public override string ToString()
//        {
//            return $"{Name} - {(IsCompleted ? "Выполнено" : "Не выполнено")}";
//        }
//    }

//    static void Main(string[] args)
//    {
//        List<Task> tasks = new List<Task>();
//        string command;

//        do
//        {
//            Console.WriteLine("\nВыберите команду:");
//            Console.WriteLine("1. Добавить задачу");
//            Console.WriteLine("2. Удалить задачу");
//            Console.WriteLine("3. Отметить задачу как выполненную");
//            Console.WriteLine("4. Показать список задач");
//            Console.WriteLine("5. Выход");
//            Console.Write("Введите номер команды: ");
//            command = Console.ReadLine();

//            switch (command)
//            {
//                case "1":
//                    AddTask(tasks);
//                    break;
//                case "2":
//                    RemoveTask(tasks);
//                    break;
//                case "3":
//                    MarkTaskAsCompleted(tasks);
//                    break;
//                case "4":
//                    ShowTasks(tasks);
//                    break;
//                case "5":
//                    Console.WriteLine("Выход из программы.");
//                    break;
//                default:
//                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
//                    break;
//            }
//        } while (command != "5");
//    }

//    static void AddTask(List<Task> tasks)
//    {
//        Console.Write("Введите название задачи: ");
//        string taskName = Console.ReadLine();
//        tasks.Add(new Task(taskName));
//        Console.WriteLine($"Задача '{taskName}' добавлена.");
//    }

//    static void RemoveTask(List<Task> tasks)
//    {
//        ShowTasks(tasks);
//        Console.Write("Введите номер задачи для удаления: ");
//        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
//        {
//            string taskName = tasks[taskNumber - 1].Name;
//            tasks.RemoveAt(taskNumber - 1);
//            Console.WriteLine($"Задача '{taskName}' удалена.");
//        }
//        else
//        {
//            Console.WriteLine("Неверный номер задачи.");
//        }
//    }

//    static void MarkTaskAsCompleted(List<Task> tasks)
//    {
//        ShowTasks(tasks);
//        Console.Write("Введите номер задачи для отметки как выполненной: ");
//        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
//        {
//            tasks[taskNumber - 1].IsCompleted = true;
//            Console.WriteLine($"Задача '{tasks[taskNumber - 1].Name}' отмечена как выполненная.");
//        }
//        else
//        {
//            Console.WriteLine("Неверный номер задачи.");
//        }
//    }

//    static void ShowTasks(List<Task> tasks)
//    {
//        if (tasks.Count == 0)
//        {
//            Console.WriteLine("Список задач пуст.");
//            return;
//        }

//        Console.WriteLine("\nСписок задач:");
//        for (int i = 0; i < tasks.Count; i++)
//        {
//            Console.WriteLine($"{i + 1}. {tasks[i]}");
//        }
//    }
//}






/*Задание 34*/
//using System;
//using System.IO;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Укажите пути к входному и выходному файлам
//        string inputFilePath = "input.txt"; // Файл для чтения
//        string outputFilePath = "output.txt"; // Файл для записи

//        try
//        {
//            // Чтение текста из входного файла
//            string text = File.ReadAllText(inputFilePath);
//            Console.WriteLine("Содержимое входного файла:");
//            Console.WriteLine(text);

//            // Изменение регистра букв
//            string modifiedText = ChangeCase(text);

//            // Запись измененного текста в выходной файл
//            File.WriteAllText(outputFilePath, modifiedText);
//            Console.WriteLine($"\nИзмененный текст записан в '{outputFilePath}'.");
//        }
//        catch (FileNotFoundException)
//        {
//            Console.WriteLine($"Файл '{inputFilePath}' не найден.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Произошла ошибка: {ex.Message}");
//        }
//    }

//    static string ChangeCase(string input)
//    {
//        char[] charArray = input.ToCharArray();
//        for (int i = 0; i < charArray.Length; i++)
//        {
//            // Если символ строчный, заменяем на прописной и наоборот
//            if (char.IsLower(charArray[i]))
//            {
//                charArray[i] = char.ToUpper(charArray[i]);
//            }
//            else if (char.IsUpper(charArray[i]))
//            {
//                charArray[i] = char.ToLower(charArray[i]);
//            }
//        }
//        return new string(charArray);
//    }
//}






/*Задание 35*/
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Получаем текущий месяц и год
//        DateTime now = DateTime.Now;
//        int year = now.Year;
//        int month = now.Month;

//        // Создаем словарь для хранения заметок
//        Dictionary<DateTime, string> notes = new Dictionary<DateTime, string>();

//        while (true)
//        {
//            // Выводим календарь
//            PrintCalendar(year, month);

//            // Ввод заметок
//            Console.WriteLine("\nВведите дату (дд/мм) для добавления заметки (или 'q' для выхода):");
//            string input = Console.ReadLine();
//            if (input.ToLower() == "q")
//                break;

//            if (DateTime.TryParseExact(input, "dd/MM", null, System.Globalization.DateTimeStyles.None, out DateTime date))
//            {
//                DateTime fullDate = new DateTime(year, month, date.Day);
//                Console.Write("Введите заметку: ");
//                string note = Console.ReadLine();
//                if (notes.ContainsKey(fullDate))
//                {
//                    notes[fullDate] = note;
//                }
//                else
//                {
//                    notes.Add(fullDate, note);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Некорректный формат даты. Пожалуйста, введите дату в формате дд/мм.");
//            }
//        }

//        // Вывод заметок
//        Console.WriteLine("\nЗаметки на текущий месяц:");
//        foreach (var note in notes)
//        {
//            Console.WriteLine($"{note.Key:dd/MM/yyyy}: {note.Value}");
//        }
//    }

//    static void PrintCalendar(int year, int month)
//    {
//        DateTime firstDay = new DateTime(year, month, 1);
//        int daysInMonth = DateTime.DaysInMonth(year, month);

//        Console.WriteLine($"\nКалендарь на {firstDay.ToString("MMMM yyyy")}");
//        Console.WriteLine("Su Mo Tu We Th Fr Sa");

//        // Печать начальных пробелов
//        for (int i = 0; i < (int)firstDay.DayOfWeek; i++)
//        {
//            Console.Write("   ");
//        }

//        // Печать дней месяца
//        for (int day = 1; day <= daysInMonth; day++)
//        {
//            Console.Write(day.ToString("D2") + " ");
//            if ((int)(firstDay.DayOfWeek + day) % 7 == 0)
//            {
//                Console.WriteLine();
//            }
//        }

//        Console.WriteLine();
//    }
//}









/*Задание 36*/
//using System;
//using System.Collections.Generic;

//class Program
//{
//    public class Student
//    {
//        public string Name { get; set; }
//        public Dictionary<string, List<int>> Grades { get; set; }

//        public Student(string name)
//        {
//            Name = name;
//            Grades = new Dictionary<string, List<int>>();
//        }

//        public void AddGrade(string subject, int grade)
//        {
//            if (!Grades.ContainsKey(subject))
//            {
//                Grades[subject] = new List<int>();
//            }
//            Grades[subject].Add(grade);
//        }

//        public void ShowGrades()
//        {
//            Console.WriteLine($"Оценки для студента: {Name}");
//            foreach (var subject in Grades)
//            {
//                Console.WriteLine($"Предмет: {subject.Key}, Оценки: {string.Join(", ", subject.Value)}");
//            }
//        }
//    }

//    static void Main(string[] args)
//    {
//        List<Student> students = new List<Student>();
//        string command;

//        do
//        {
//            Console.WriteLine("\nВыберите команду:");
//            Console.WriteLine("1. Добавить студента");
//            Console.WriteLine("2. Добавить оценку студенту");
//            Console.WriteLine("3. Показать успеваемость студентов");
//            Console.WriteLine("4. Выход");
//            Console.Write("Введите номер команды: ");
//            command = Console.ReadLine();

//            switch (command)
//            {
//                case "1":
//                    AddStudent(students);
//                    break;
//                case "2":
//                    AddGradeToStudent(students);
//                    break;
//                case "3":
//                    ShowStudentsGrades(students);
//                    break;
//                case "4":
//                    Console.WriteLine("Выход из программы.");
//                    break;
//                default:
//                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
//                    break;
//            }
//        } while (command != "4");
//    }

//    static void AddStudent(List<Student> students)
//    {
//        Console.Write("Введите имя студента: ");
//        string studentName = Console.ReadLine();
//        students.Add(new Student(studentName));
//        Console.WriteLine($"Студент '{studentName}' добавлен.");
//    }

//    static void AddGradeToStudent(List<Student> students)
//    {
//        Console.Write("Введите имя студента: ");
//        string studentName = Console.ReadLine();
//        Student student = students.Find(s => s.Name.Equals(studentName, StringComparison.OrdinalIgnoreCase));

//        if (student != null)
//        {
//            Console.Write("Введите предмет: ");
//            string subject = Console.ReadLine();
//            Console.Write("Введите оценку: ");
//            if (int.TryParse(Console.ReadLine(), out int grade))
//            {
//                student.AddGrade(subject, grade);
//                Console.WriteLine($"Оценка {grade} по предмету '{subject}' добавлена студенту '{studentName}'.");
//            }
//            else
//            {
//                Console.WriteLine("Неверный формат оценки.");
//            }
//        }
//        else
//        {
//            Console.WriteLine($"Студент '{studentName}' не найден.");
//        }
//    }

//    static void ShowStudentsGrades(List<Student> students)
//    {
//        if (students.Count == 0)
//        {
//            Console.WriteLine("Список студентов пуст.");
//            return;
//        }

//        foreach (var student in students)
//        {
//            student.ShowGrades();
//        }
//    }
//}










/*Задание 37*/
//using System;
//using System.Collections.Generic;

//class Program
//{
//    public class Contact
//    {
//        public string Name { get; set; }
//        public string Phone { get; set; }
//        public string Email { get; set; }

//        public Contact(string name, string phone, string email)
//        {
//            Name = name;
//            Phone = phone;
//            Email = email;
//        }

//        public override string ToString()
//        {
//            return $"Имя: {Name}, Телефон: {Phone}, Email: {Email}";
//        }
//    }

//    static void Main(string[] args)
//    {
//        List<Contact> contacts = new List<Contact>();
//        string command;

//        do
//        {
//            Console.WriteLine("\nВыберите команду:");
//            Console.WriteLine("1. Добавить контакт");
//            Console.WriteLine("2. Удалить контакт");
//            Console.WriteLine("3. Редактировать контакт");
//            Console.WriteLine("4. Найти контакт");
//            Console.WriteLine("5. Показать все контакты");
//            Console.WriteLine("6. Выход");
//            Console.Write("Введите номер команды: ");
//            command = Console.ReadLine();

//            switch (command)
//            {
//                case "1":
//                    AddContact(contacts);
//                    break;
//                case "2":
//                    RemoveContact(contacts);
//                    break;
//                case "3":
//                    EditContact(contacts);
//                    break;
//                case "4":
//                    FindContact(contacts);
//                    break;
//                case "5":
//                    ShowAllContacts(contacts);
//                    break;
//                case "6":
//                    Console.WriteLine("Выход из программы.");
//                    break;
//                default:
//                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
//                    break;
//            }
//        } while (command != "6");
//    }

//    static void AddContact(List<Contact> contacts)
//    {
//        Console.Write("Введите имя: ");
//        string name = Console.ReadLine();
//        Console.Write("Введите телефон: ");
//        string phone = Console.ReadLine();
//        Console.Write("Введите email: ");
//        string email = Console.ReadLine();
//        contacts.Add(new Contact(name, phone, email));
//        Console.WriteLine($"Контакт '{name}' добавлен.");
//    }

//    static void RemoveContact(List<Contact> contacts)
//    {
//        Console.Write("Введите имя контакта для удаления: ");
//        string name = Console.ReadLine();
//        Contact contactToRemove = contacts.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

//        if (contactToRemove != null)
//        {
//            contacts.Remove(contactToRemove);
//            Console.WriteLine($"Контакт '{name}' удален.");
//        }
//        else
//        {
//            Console.WriteLine($"Контакт '{name}' не найден.");
//        }
//    }

//    static void EditContact(List<Contact> contacts)
//    {
//        Console.Write("Введите имя контакта для редактирования: ");
//        string name = Console.ReadLine();
//        Contact contactToEdit = contacts.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

//        if (contactToEdit != null)
//        {
//            Console.Write("Введите новый телефон: ");
//            contactToEdit.Phone = Console.ReadLine();
//            Console.Write("Введите новый email: ");
//            contactToEdit.Email = Console.ReadLine();
//            Console.WriteLine($"Контакт '{name}' обновлен.");
//        }
//        else
//        {
//            Console.WriteLine($"Контакт '{name}' не найден.");
//        }
//    }

//    static void FindContact(List<Contact> contacts)
//    {
//        Console.Write("Введите имя контакта для поиска: ");
//        string name = Console.ReadLine();
//        Contact contactToFind = contacts.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

//        if (contactToFind != null)
//        {
//            Console.WriteLine("Найденный контакт:");
//            Console.WriteLine(contactToFind);
//        }
//        else
//        {
//            Console.WriteLine($"Контакт '{name}' не найден.");
//        }
//    }

//    static void ShowAllContacts(List<Contact> contacts)
//    {
//        if (contacts.Count == 0)
//        {
//            Console.WriteLine("Список контактов пуст.");
//            return;
//        }

//        Console.WriteLine("\nСписок всех контактов:");
//        foreach (var contact in contacts)
//        {
//            Console.WriteLine(contact);
//        }
//    }
//}













//задание 38
//using System;

//class Program
//{
//    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
//    static int currentPlayer = 1; // 1 = Player 1, 2 = Player 2
//    static int choice;
//    static int row, col;
//    static int player1Wins = 0, player2Wins = 0;
//    static bool playing = true;

//    static void Main()
//    {
//        while (playing)
//        {
//            Console.Clear();
//            Console.WriteLine("Крестики-нолики");
//            Console.WriteLine("Игрок 1 (X) против Игрока 2 (O)");
//            Console.WriteLine();

//            // Печать игрового поля
//            PrintBoard();

//            // Ход текущего игрока
//            choice = GetPlayerChoice();
//            UpdateBoard(choice);

//            // Проверка на победу
//            if (CheckWin())
//            {
//                Console.Clear();
//                PrintBoard();
//                Console.WriteLine($"Игрок {currentPlayer} выиграл!");
//                if (currentPlayer == 1)
//                    player1Wins++;
//                else
//                    player2Wins++;

//                Console.WriteLine($"Игрок 1: {player1Wins} | Игрок 2: {player2Wins}");
//                Console.WriteLine("Нажмите любую клавишу для продолжения...");
//                Console.ReadKey();
//                ResetBoard();
//            }
//            else if (IsBoardFull())
//            {
//                Console.Clear();
//                PrintBoard();
//                Console.WriteLine("Ничья!");
//                Console.WriteLine("Нажмите любую клавишу для продолжения...");
//                Console.ReadKey();
//                ResetBoard();
//            }
//            else
//            {
//                // Смена игрока
//                currentPlayer = (currentPlayer % 2) + 1;
//            }
//        }
//    }

//    static void PrintBoard()
//    {
//        Console.WriteLine(" " + board[0] + " | " + board[1] + " | " + board[2]);
//        Console.WriteLine("---|---|---");
//        Console.WriteLine(" " + board[3] + " | " + board[4] + " | " + board[5]);
//        Console.WriteLine("---|---|---");
//        Console.WriteLine(" " + board[6] + " | " + board[7] + " | " + board[8]);
//    }

//    static int GetPlayerChoice()
//    {
//        int validChoice;
//        do
//        {
//            Console.WriteLine($"Игрок {currentPlayer}, выберите место (1-9): ");
//        } while (!int.TryParse(Console.ReadLine(), out validChoice) || validChoice < 1 || validChoice > 9 || board[validChoice - 1] == 'X' || board[validChoice - 1] == 'O');

//        return validChoice;
//    }

//    static void UpdateBoard(int choice)
//    {
//        char symbol = currentPlayer == 1 ? 'X' : 'O';
//        board[choice - 1] = symbol;
//    }

//    static bool CheckWin()
//    {
//        char symbol = currentPlayer == 1 ? 'X' : 'O';

//        // Проверка горизонталей, вертикалей и диагоналей
//        return
//            (board[0] == symbol && board[1] == symbol && board[2] == symbol) || // Горизонтальные
//            (board[3] == symbol && board[4] == symbol && board[5] == symbol) ||
//            (board[6] == symbol && board[7] == symbol && board[8] == symbol) ||
//            (board[0] == symbol && board[3] == symbol && board[6] == symbol) || // Вертикальные
//            (board[1] == symbol && board[4] == symbol && board[7] == symbol) ||
//            (board[2] == symbol && board[5] == symbol && board[8] == symbol) ||
//            (board[0] == symbol && board[4] == symbol && board[8] == symbol) || // Диагонали
//            (board[2] == symbol && board[4] == symbol && board[6] == symbol);
//    }

//    static bool IsBoardFull()
//    {
//        foreach (var spot in board)
//        {
//            if (spot != 'X' && spot != 'O')
//            {
//                return false;
//            }
//        }
//        return true;
//    }

//    static void ResetBoard()
//    {
//        board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
//    }
//}
















//задание 39
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Добро пожаловать в игру 'Быки и коровы'!");
//        Console.WriteLine("Попробуйте угадать загаданное 4-значное число.");
//        Console.WriteLine("Для выхода из игры введите 'exit'.");

//        string secretNumber = GenerateSecretNumber();
//        bool gameOver = false;

//        while (!gameOver)
//        {
//            Console.Write("Введите ваш вариант (4 цифры): ");
//            string guess = Console.ReadLine();

//            if (guess.ToLower() == "exit")
//            {
//                Console.WriteLine($"Выход из игры. Загаданное число было {secretNumber}.");
//                break;
//            }

//            if (!IsValidGuess(guess))
//            {
//                Console.WriteLine("Некорректный ввод. Введите четырехзначное число, не содержащие одинаковые цифры.");
//                continue;
//            }

//            (int bulls, int cows) = GetBullsAndCows(secretNumber, guess);

//            Console.WriteLine($"{bulls} быков, {cows} коров.");

//            if (bulls == 4)
//            {
//                Console.WriteLine("Поздравляем! Вы угадали число!");
//                gameOver = true;
//            }
//        }
//    }

//    static string GenerateSecretNumber()
//    {
//        Random random = new Random();
//        string number;
//        do
//        {
//            number = random.Next(1000, 10000).ToString();
//        } while (HasDuplicateDigits(number));
//        return number;
//    }

//    static bool IsValidGuess(string guess)
//    {
//        if (guess.Length != 4)
//            return false;

//        if (!int.TryParse(guess, out _))
//            return false;

//        return !HasDuplicateDigits(guess);
//    }

//    static bool HasDuplicateDigits(string number)
//    {
//        return number.Length != new HashSet<char>(number).Count;
//    }

//    static (int bulls, int cows) GetBullsAndCows(string secretNumber, string guess)
//    {
//        int bulls = 0, cows = 0;

//        for (int i = 0; i < 4; i++)
//        {
//            if (guess[i] == secretNumber[i])
//            {
//                bulls++;
//            }
//            else if (secretNumber.Contains(guess[i]))
//            {
//                cows++;
//            }
//        }

//        return (bulls, cows);
//    }
//}














//задание 40
//using System;

//class ATM
//{
//    private static decimal balance = 0; // Изначально баланс равен 0

//    static void Main()
//    {
//        bool running = true;

//        while (running)
//        {
//            Console.Clear();
//            Console.WriteLine("Банкомат");
//            Console.WriteLine("1. Просмотр баланса");
//            Console.WriteLine("2. Внесение средств");
//            Console.WriteLine("3. Снятие средств");
//            Console.WriteLine("4. Выход");

//            Console.Write("Выберите действие (1-4): ");
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    ViewBalance();
//                    break;
//                case "2":
//                    Deposit();
//                    break;
//                case "3":
//                    Withdraw();
//                    break;
//                case "4":
//                    running = false;
//                    break;
//                default:
//                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
//                    break;
//            }
//        }
//    }

//    static void ViewBalance()
//    {
//        Console.WriteLine($"Ваш текущий баланс: {balance:C}");
//        Console.WriteLine("Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }

//    static void Deposit()
//    {
//        Console.Write("Введите сумму для внесения: ");
//        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
//        {
//            balance += amount;
//            Console.WriteLine($"Сумма {amount:C} успешно внесена.");
//        }
//        else
//        {
//            Console.WriteLine("Неверная сумма. Попробуйте еще раз.");
//        }
//        Console.WriteLine("Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }

//    static void Withdraw()
//    {
//        Console.Write("Введите сумму для снятия: ");
//        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
//        {
//            if (amount <= balance)
//            {
//                balance -= amount;
//                Console.WriteLine($"Сумма {amount:C} успешно снята.");
//            }
//            else
//            {
//                Console.WriteLine("Недостаточно средств для снятия.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Неверная сумма. Попробуйте еще раз.");
//        }
//        Console.WriteLine("Нажмите любую клавишу для продолжения...");
//        Console.ReadKey();
//    }
//}


//Задание 41
//using System;
//using System.IO;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string csvFilePath = "data.csv";

//        if (File.Exists(csvFilePath))
//        {
//            // Чтение всех строк из CSV-файла
//            string[] lines = File.ReadAllLines(csvFilePath);

//            // Вывод заголовков
//            string[] headers = lines[0].Split(',');
//            Console.WriteLine(string.Join("\t", headers));
//            Console.WriteLine(new string('-', 40));

//            // Вывод данных
//            for (int i = 1; i < lines.Length; i++)
//            {
//                string[] fields = lines[i].Split(',');
//                Console.WriteLine(string.Join("\t", fields));
//            }
//        }
//        else
//        {
//            Console.WriteLine($"Файл '{csvFilePath}' не найден.");
//        }
//    }
//}







//Задание 42
//using System;

//class TemperatureCalculator
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите температуры за каждый день недели (градусы Цельсия):");

//        double[] temperatures = new double[7]; 


//        for (int i = 0; i < 7; i++)
//        {
//            Console.Write($"День {i + 1}: ");
//            if (!double.TryParse(Console.ReadLine(), out temperatures[i]))
//            {
//                Console.WriteLine("Ошибка: введите число.");
//                i--; 
//            }
//        }

//        double sum = 0;
//        for (int i = 0; i < 7; i++)
//        {
//            sum += temperatures[i];
//        }
//        double averageTemperature = sum / 7;

//        Console.WriteLine($"Средняя температура за неделю: {averageTemperature:F2} градусов Цельсия.");
//    }
//}








//Задание 43 -
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static int width = 20;
    static int height = 10;
    static int score = 0;
    static bool gameOver = false;

    static List<Position> snake = new List<Position>();
    static Position food = new Position();
    static Position direction = new Position(1, 0);

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        InitializeGame();
        while (!gameOver)
        {
            Draw();
            Input();
            Logic();
            Thread.Sleep(100); 
        }
        Console.SetCursorPosition(0, height + 1);
        Console.WriteLine("Game Over! Your score: " + score);
    }

    static void InitializeGame()
    {
        snake.Add(new Position(width / 2, height / 2)); 
        GenerateFood();
    }

    static void GenerateFood()
    {
        Random rand = new Random();
        food.X = rand.Next(0, width);
        food.Y = rand.Next(0, height);
    }

    static void Draw()
    {
        Console.Clear();
        Console.SetCursorPosition(food.X, food.Y);
        Console.Write("F"); 

        foreach (var segment in snake)
        {
            Console.SetCursorPosition(segment.X, segment.Y);
            Console.Write("O");
        }

        Console.SetCursorPosition(0, height);
        Console.WriteLine("Score: " + score);
    }

    static void Input()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.W:
                    direction = new Position(0, -1);
                    break;
                case ConsoleKey.S:
                    direction = new Position(0, 1);
                    break;
                case ConsoleKey.A:
                    direction = new Position(-1, 0);
                    break;
                case ConsoleKey.D:
                    direction = new Position(1, 0);
                    break;
            }
        }
    }

    static void Logic()
    {
        Position head = new Position(snake.First().X + direction.X, snake.First().Y + direction.Y);

        if (head.X < 0head.Y < 0snake.Skip(1).Any(s => s.X == head.X && s.Y == head.Y))
        {
            gameOver = true;
            return;
        }

        snake.Insert(0, head); 

        if (head.X == food.X && head.Y == food.Y)
        {
            score++;
            GenerateFood(); 
        }
        else
        {
            snake.RemoveAt(snake.Count - 1); 
        }
    }
}

class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position() { }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}*/








//задание 44
//using System;
//using System.IO;
//using System.Linq;
//using System.Threading;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string directoryPath = @"C:\Users\gosha\OneDrive\Рабочий стол\оленьке ёпт\44"; // Укажите путь к директории
//        string backupDirectoryPath = Path.Combine(directoryPath, "Backups");

//        // Создаем директорию для резервных копий, если она не существует
//        if (!Directory.Exists(backupDirectoryPath))
//        {
//            Directory.CreateDirectory(backupDirectoryPath);
//        }

//        // Словарь для хранения хешей файлов
//        var fileHashes = new System.Collections.Generic.Dictionary<string, string>();

//        while (true)
//        {
//            // Получаем все текстовые файлы в указанной директории
//            var files = Directory.GetFiles(directoryPath, "*.txt");

//            foreach (var file in files)
//            {
//                // Вычисляем хеш файла
//                string fileHash = ComputeFileHash(file);

//                // Проверяем, изменился ли файл
//                if (!fileHashes.ContainsKey(file) || fileHashes[file] != fileHash)
//                {
//                    // Сохраняем резервную копию с отметкой времени
//                    string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
//                    string backupFileName = Path.Combine(backupDirectoryPath, $"{Path.GetFileNameWithoutExtension(file)}_{timestamp}.txt");
//                    File.Copy(file, backupFileName);

//                    // Обновляем хеш файла в словаре
//                    fileHashes[file] = fileHash;

//                    Console.WriteLine($"Файл '{file}' изменен. Создана резервная копия: '{backupFileName}'");
//                }
//            }

//            // Задержка перед следующей проверкой
//            Thread.Sleep(5000); // Проверка каждые 5 секунд
//        }
//    }

//    static string ComputeFileHash(string filePath)
//    {
//        using (var stream = File.OpenRead(filePath))
//        {
//            using (var sha256 = System.Security.Cryptography.SHA256.Create())
//            {
//                byte[] hash = sha256.ComputeHash(stream);
//                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
//            }
//        }
//    }
//}




//задание 45
//using System;
//using System.Collections.Generic;
//using System.IO;

//class Program
//{
//    public class Sale
//    {
//        public string ProductName { get; set; }
//        public int Quantity { get; set; }
//        public decimal Price { get; set; }

//        public Sale(string productName, int quantity, decimal price)
//        {
//            ProductName = productName;
//            Quantity = quantity;
//            Price = price;
//        }

//        public decimal Total => Quantity * Price;
//    }

//    static void Main(string[] args)
//    {
//        List<Sale> sales = new List<Sale>();
//        string command;

//        do
//        {
//            Console.WriteLine("\nВыберите команду:");
//            Console.WriteLine("1. Добавить продажу");
//            Console.WriteLine("2. Сгенерировать отчет");
//            Console.WriteLine("3. Выход");
//            Console.Write("Введите номер команды: ");
//            command = Console.ReadLine();

//            switch (command)
//            {
//                case "1":
//                    AddSale(sales);
//                    break;
//                case "2":
//                    GenerateReport(sales);
//                    break;
//                case "3":
//                    Console.WriteLine("Выход из программы.");
//                    break;
//                default:
//                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
//                    break;
//            }
//        } while (command != "3");
//    }

//    static void AddSale(List<Sale> sales)
//    {
//        Console.Write("Введите название продукта: ");
//        string productName = Console.ReadLine();
//        Console.Write("Введите количество: ");
//        if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
//        {
//            Console.Write("Введите цену: ");
//            if (decimal.TryParse(Console.ReadLine(), out decimal price) && price >= 0)
//            {
//                sales.Add(new Sale(productName, quantity, price));
//                Console.WriteLine($"Продажа '{productName}' добавлена.");
//            }
//            else
//            {
//                Console.WriteLine("Неверный формат цены.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Неверный формат количества.");
//        }
//    }

//    static void GenerateReport(List<Sale> sales)
//    {
//        if (sales.Count == 0)
//        {
//            Console.WriteLine("Нет данных для генерации отчета.");
//            return;
//        }

//        string reportFilePath = "SalesReport.txt";
//        using (StreamWriter writer = new StreamWriter(reportFilePath))
//        {
//            writer.WriteLine("Отчет по продажам");
//            writer.WriteLine("-------------------------");
//            writer.WriteLine("Продукт\tКоличество\tЦена\tИтого");

//            foreach (var sale in sales)
//            {
//                writer.WriteLine($"{sale.ProductName}\t{sale.Quantity}\t{sale.Price:C}\t{sale.Total:C}");
//            }

//            writer.WriteLine("-------------------------");
//            writer.WriteLine($"Общая сумма: {sales.Sum(s => s.Total):C}");
//        }

//        Console.WriteLine($"Отчет сгенерирован и сохранен в '{reportFilePath}'.");
//    }
//}









//задание 46
/*using System;
using System.Collections.Generic;

class Program
{
    static List<Visitor> visitors = new List<Visitor>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Учет посетителей мероприятия");
            Console.WriteLine("1. Добавить посетителя");
            Console.WriteLine("2. Отметить присутствие");
            Console.WriteLine("3. Вывести список всех посетителей");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddVisitor();
                    break;
                case "2":
                    MarkPresence();
                    break;
                case "3":
                    DisplayVisitors();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                    break;
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

    static void AddVisitor()
    {
        Console.Write("Введите имя посетителя: ");
        string name = Console.ReadLine();
        visitors.Add(new Visitor(name));
        Console.WriteLine("Посетитель добавлен.");
    }

    static void MarkPresence()
    {
        Console.Write("Введите имя посетителя для отметки присутствия: ");
        string name = Console.ReadLine();
        Visitor visitor = visitors.Find(v => v.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (visitor != null)
        {
            visitor.IsPresent = true;
            Console.WriteLine("Присутствие отмечено.");
        }
        else
        {
            Console.WriteLine("Посетитель не найден.");
        }
    }

    static void DisplayVisitors()
    {
        Console.WriteLine("Список всех посетителей:");
        foreach (var visitor in visitors)
        {
            string presenceStatus = visitor.IsPresent ? "Присутствует" : "Не присутствует";
            Console.WriteLine($"- {visitor.Name}: {presenceStatus}");
        }
    }
}

class Visitor
{
    public string Name { get; set; }
    public bool IsPresent { get; set; }

    public Visitor(string name)
    {
        Name = name;
        IsPresent = false;
    }
}*/






//задание 47
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static List<TaskItem> tasks = new List<TaskItem>();
    static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

    static async Task Main(string[] args)
    {
        Console.WriteLine("Планировщик задач");
        Task.Run(() => MonitorTasks(cancellationTokenSource.Token));

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Создать задачу");
            Console.WriteLine("2. Выход");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateTask();
            }
            else if (choice == "2")
            {
                cancellationTokenSource.Cancel();
                break;
            }
            else
            {
                Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
            }
        }
    }

    static void CreateTask()
    {
        Console.Write("Введите описание задачи: ");
        string description = Console.ReadLine();

        Console.Write("Введите время выполнения (в формате HH:mm): ");
        string timeInput = Console.ReadLine();

        if (DateTime.TryParse(timeInput, out DateTime executionTime))
        {
            if (executionTime < DateTime.Now)
            {
                Console.WriteLine("Время выполнения должно быть в будущем.");
                return;
            }

            tasks.Add(new TaskItem(description, executionTime));
            Console.WriteLine("Задача добавлена.");
        }
        else
        {
            Console.WriteLine("Неверный формат времени.");
        }
    }

    static async Task MonitorTasks(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            var now = DateTime.Now;

            foreach (var task in tasks.ToList())
            {
                if (task.ExecutionTime <= now)
                {
                    Console.WriteLine($"Уведомление: Время выполнить задачу \"{task.Description}\"!");
                    tasks.Remove(task); 
                }
            }

            await Task.Delay(1000); 
        }
    }
}

class TaskItem
{
    public string Description { get; set; }
    public DateTime ExecutionTime { get; set; }

    public TaskItem(string description, DateTime executionTime)
    {
        Description = description;
        ExecutionTime = executionTime;
    }
}*/





//задание 48
/*using System;
using System.Collections.Generic;
using System.Linq;

class SalesAnalyzer
{
    static void Main(string[] args)
    {
        // Пример данных о продажах (можно заменить на чтение из файла или базы данных)
        List<Sale> sales = new List<Sale>()
        {
            new Sale("Товар A", 10, 100),
            new Sale("Товар B", 5, 50),
            new Sale("Товар A", 15, 150),
            new Sale("Товар C", 20, 200),
            new Sale("Товар B", 8, 80),
        };

        // Анализ продаж
        Dictionary<string, SaleStats> salesStats = AnalyzeSales(sales);

        // Вывод статистики
        Console.WriteLine("Статистика продаж:");
        Console.WriteLine("---------------------");
        Console.WriteLine($"Общая сумма продаж: {salesStats.Values.Sum(s => s.TotalAmount):C}"); // Общая сумма
        Console.WriteLine();
        Console.WriteLine("Статистика по товарам:");

        foreach (var item in salesStats)
        {
            Console.WriteLine($"Товар: {item.Key}");
            Console.WriteLine($"  Количество проданных единиц: {item.Value.QuantitySold}");
            Console.WriteLine($"  Сумма продаж: {item.Value.TotalAmount:C}");
            Console.WriteLine();
        }
    }

    static Dictionary<string, SaleStats> AnalyzeSales(List<Sale> sales)
    {
        Dictionary<string, SaleStats> stats = new Dictionary<string, SaleStats>();

        foreach (Sale sale in sales)
        {
            if (stats.ContainsKey(sale.ProductName))
            {
                stats[sale.ProductName].QuantitySold += sale.Quantity;
                stats[sale.ProductName].TotalAmount += sale.Price * sale.Quantity;
            }
            else
            {
                stats.Add(sale.ProductName, new SaleStats(sale.Quantity, sale.Price * sale.Quantity));
            }
        }

        return stats;
    }
}

class Sale
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Sale(string productName, int quantity, double price)
    {
        ProductName = productName;
        Quantity = quantity;
        Price = price;
    }
}

class SaleStats
{
    public int QuantitySold { get; set; }
    public double TotalAmount { get; set; }

    public SaleStats(int quantitySold, double totalAmount)
    {
        QuantitySold = quantitySold;
        TotalAmount = totalAmount;
    }
}*/







//задание 49
/*using System;
using System.Linq;

class Hangman
{
    static void Main(string[] args)
    {

        string[] words = { "кот", "собака", "птица", "дерево", "вода", "солнце", "звезда", "луна" };


        Random random = new Random();
        string secretWord = words[random.Next(words.Length)];

        char[] guessedLetters = new char[secretWord.Length];
        for (int i = 0; i < secretWord.Length; i++)
        {
            guessedLetters[i] = '_';
        }
        int attemptsLeft = 6;

        while (attemptsLeft > 0 && !guessedLetters.All(c => c != '_'))
        {
            Console.WriteLine("\nСлово:");
            Console.WriteLine(string.Join(" ", guessedLetters));
            Console.WriteLine($"Осталось попыток: {attemptsLeft}");

            Console.Write("Введите букву: ");
            char guess = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (secretWord.Contains(guess))
            {
                Console.WriteLine("Верно!");
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == guess)
                    {
                        guessedLetters[i] = guess;
                    }
                }
            }
            else
            {
                Console.WriteLine("Неверно!");
                attemptsLeft--;
            }
        }

        if (guessedLetters.All(c => c != '_'))
        {
            Console.WriteLine("\nПоздравляю! Вы угадали слово: " + secretWord);
        }
        else
        {
            Console.WriteLine("\nУ вас закончились попытки! Слово было: " + secretWord);
        }

        Console.ReadKey();
    }
}*/






//задание 50 +-
/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SurveySystem surveySystem = new SurveySystem();
        surveySystem.Run();
    }
}

public class SurveySystem
{
    private List<Survey> surveys = new List<Survey>();

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("1. Создать опрос");
            Console.WriteLine("2. Провести опрос");
            Console.WriteLine("3. Просмотреть результаты");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateSurvey();
                    break;
                case "2":
                    ConductSurvey();
                    break;
                case "3":
                    ViewResults();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    private void CreateSurvey()
    {
        Console.Write("Введите название опроса: ");
        string title = Console.ReadLine();
        Survey survey = new Survey(title);

        while (true)
        {
            Console.Write("Введите вопрос (или 'exit' для завершения): ");
            string question = Console.ReadLine();
            if (question.ToLower() == "exit") break;

            List<string> options = new List<string>();
            while (true)
            {
                Console.Write("Введите вариант ответа (или 'exit' для завершения): ");
                string option = Console.ReadLine();
                if (option.ToLower() == "exit") break;
                options.Add(option);
            }

            survey.AddQuestion(new Question(question, options));
        }

        surveys.Add(survey);
        Console.WriteLine("Опрос успешно создан!");
    }

    private void ConductSurvey()
    {
        if (surveys.Count == 0)
        {
            Console.WriteLine("Нет доступных опросов.");
            return;
        }

        Console.WriteLine("Выберите опрос:");
        for (int i = 0; i < surveys.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {surveys[i].Title}");
        }

        int surveyIndex = int.Parse(Console.ReadLine()) - 1;
        if (surveyIndex < 0 || surveyIndex >= surveys.Count)
        {
            Console.WriteLine("Неверный выбор.");
            return;
        }

        Survey selectedSurvey = surveys[surveyIndex];
        selectedSurvey.Conduct();
    }

    private void ViewResults()
    {
        if (surveys.Count == 0)
        {
            Console.WriteLine("Нет доступных опросов.");
            return;
        }

        Console.WriteLine("Выберите опрос для просмотра результатов:");
        for (int i = 0; i < surveys.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {surveys[i].Title}");
        }

        int surveyIndex = int.Parse(Console.ReadLine()) - 1;
        if (surveyIndex < 0 || surveyIndex >= surveys.Count)
        {
            Console.WriteLine("Неверный выбор.");
            return;
        }

        surveys[surveyIndex].DisplayResults();
    }
}

public class Survey
{
    public string Title { get; }
    private List<Question> questions = new List<Question>();

    public Survey(string title)
    {
        Title = title;
    }

    public void AddQuestion(Question question)
    {
        questions.Add(question);
    }

    public void Conduct()
    {
        Console.WriteLine($"Проведение опроса: {Title}");
        foreach (var question in questions)
        {
            question.Ask();
        }
    }

    public void DisplayResults()
    {
        Console.WriteLine($"Результаты опроса: {Title}");
        foreach (var question in questions)
        {
            question.DisplayResults();
        }
    }
}

public class Question
{
    public string Text { get; }
    private List<string> options;
    private Dictionary<string, int> responses = new Dictionary<string, int>();

    public Question(string text, List<string> options)
    {
        Text = text;
        this.options = options;
        foreach (var option in options)
        {
            responses[option] = 0;
        }
    }

    public void Ask()
    {
        Console.WriteLine(Text);
        for (int i = 0; i < options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < options.Count)
        {
            responses[options[choice]]++;
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    public void DisplayResults()
    {
        Console.WriteLine($"Вопрос: {Text}");
        foreach (var option in options)
        {
            Console.WriteLine($"{option}: {responses[option]} ответов");
        }
    }
}*/




//задание 51
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;

//class Program
//{
//    public class WeatherData
//    {
//        public DateTime Date { get; set; }
//        public double Temperature { get; set; }
//        public double Precipitation { get; set; }

//        public WeatherData(DateTime date, double temperature, double precipitation)
//        {
//            Date = date;
//            Temperature = temperature;
//            Precipitation = precipitation;
//        }
//    }

//    public class MonthlyStats
//    {
//        public double TotalTemperature { get; set; }
//        public double TotalPrecipitation { get; set; }
//        public int Count { get; set; }
//    }

//    static void Main(string[] args)
//    {
//        string csvFilePath = "weather_data.csv";

//        if (File.Exists(csvFilePath))
//        {
//            List<WeatherData> weatherDataList = new List<WeatherData>();

//            // Чтение данных из CSV-файла
//            string[] lines = File.ReadAllLines(csvFilePath);
//            for (int i = 1; i < lines.Length; i++) // Пропускаем заголовок
//            {
//                string[] fields = lines[i].Split(',');
//                if (DateTime.TryParseExact(fields[0], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date) &&
//                    double.TryParse(fields[1], out double temperature) &&
//                    double.TryParse(fields[2], out double precipitation))
//                {
//                    weatherDataList.Add(new WeatherData(date, temperature, precipitation));
//                }
//                else
//                {
//                    Console.WriteLine($"Ошибка при парсинге строки: {lines[i]}");
//                }
//            }

//            // Анализ данных
//            AnalyzeWeatherData(weatherDataList);
//        }
//        else
//        {
//            Console.WriteLine($"Файл '{csvFilePath}' не найден.");
//        }
//    }

//    static void AnalyzeWeatherData(List<WeatherData> weatherDataList)
//    {
//        var monthlyData = new Dictionary<int, MonthlyStats>();

//        foreach (var data in weatherDataList)
//        {
//            int month = data.Date.Month;

//            if (!monthlyData.ContainsKey(month))
//            {
//                monthlyData[month] = new MonthlyStats();
//            }

//            var currentData = monthlyData[month];
//            currentData.TotalTemperature += data.Temperature;
//            currentData.TotalPrecipitation += data.Precipitation;
//            currentData.Count++;
//        }

//        Console.WriteLine("Статистика по месяцам:");
//        Console.WriteLine("Месяц\tСредняя температура\tОбщее количество осадков");

//        for (int month = 1; month <= 12; month++)
//        {
//            if (monthlyData.ContainsKey(month))
//            {
//                var data = monthlyData[month];
//                double averageTemperature = data.TotalTemperature / data.Count;
//                Console.WriteLine($"{month}\t{averageTemperature:F2}\t\t\t{data.TotalPrecipitation:F2}");
//            }
//            else
//            {
//                Console.WriteLine($"{month}\tНет данных\t\t\tНет данных");
//            }
//        }
//    }
//}







//задание 52
/*using System;
using System.Collections.Generic;

class LibraryManager
{
    static List<Book> books = new List<Book>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nБиблиотека:");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Удалить книгу");
            Console.WriteLine("3. Редактировать книгу");
            Console.WriteLine("4. Найти книгу");
            Console.WriteLine("5. Вывести список книг");
            Console.WriteLine("6. Выход");
            Console.Write("Выберите действие: ");

            int choice = GetIntInput();

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    RemoveBook();
                    break;
                case 3:
                    EditBook();
                    break;
                case 4:
                    FindBook();
                    break;
                case 5:
                    ListBooks();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.WriteLine("\nДобавление книги:");
        Console.Write("Введите название книги: ");
        string title = Console.ReadLine();
        Console.Write("Введите автора: ");
        string author = Console.ReadLine();
        Console.Write("Введите год издания: ");
        int year = GetIntInput();

        books.Add(new Book(title, author, year));
        Console.WriteLine("Книга успешно добавлена!");
    }

    static void RemoveBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("\nСписок книг пуст.");
            return;
        }

        ListBooks();

        Console.Write("Введите номер книги для удаления: ");
        int bookIndex = GetIntInput() - 1;

        if (bookIndex < 0 || bookIndex >= books.Count)
        {
            Console.WriteLine("Неверный номер книги.");
            return;
        }

        books.RemoveAt(bookIndex);
        Console.WriteLine("Книга успешно удалена!");
    }

    static void EditBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("\nСписок книг пуст.");
            return;
        }

        ListBooks();

        Console.Write("Введите номер книги для редактирования: ");
        int bookIndex = GetIntInput() - 1;

        if (bookIndex < 0 || bookIndex >= books.Count)
        {
            Console.WriteLine("Неверный номер книги.");
            return;
        }

        Book book = books[bookIndex];

        Console.WriteLine("\nРедактирование книги:");
        Console.Write($"Текущее название: {book.Title}. Введите новое название (или нажмите Enter, чтобы оставить без изменений): ");
        string newTitle = Console.ReadLine();
        if (!string.IsNullOrEmpty(newTitle))
        {
            book.Title = newTitle;
        }

        Console.Write($"Текущий автор: {book.Author}. Введите нового автора (или нажмите Enter, чтобы оставить без изменений): ");
        string newAuthor = Console.ReadLine();
        if (!string.IsNullOrEmpty(newAuthor))
        {
            book.Author = newAuthor;
        }

        Console.Write($"Текущий год издания: {book.Year}. Введите новый год издания (или нажмите Enter, чтобы оставить без изменений): ");
        string newYearStr = Console.ReadLine();
        if (!string.IsNullOrEmpty(newYearStr) && int.TryParse(newYearStr, out int newYear))
        {
            book.Year = newYear;
        }

        Console.WriteLine("Книга успешно отредактирована!");
    }

    static void FindBook()
    {
        Console.WriteLine("\nПоиск книги:");
        Console.Write("Введите строку для поиска (название, автор или год издания): ");
        string searchTerm = Console.ReadLine();

        List<Book> foundBooks = books.Where(b =>
            b.Title.Contains(searchTerm) ||
            b.Author.Contains(searchTerm) ||
            b.Year.ToString().Contains(searchTerm)
        ).ToList();

        if (foundBooks.Count == 0)
        {
            Console.WriteLine("Книги не найдены.");
            return;
        }

        Console.WriteLine("\nНайденные книги:");
        for (int i = 0; i < foundBooks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {foundBooks[i]}");
        }
    }

    static void ListBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("\nСписок книг пуст.");
            return;
        }

        Console.WriteLine("\nСписок книг:");
        for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {books[i]}");
        }
    }

    static int GetIntInput()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                return input;
            }
            else
            {
                Console.Write("Ошибка: введите число. Повторите ввод: ");
            }
        }
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"Название: {Title}, Автор: {Author}, Год издания: {Year}";
    }
}*/


