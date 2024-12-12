class Program
{
    static void Main(string[] args)
    {
        // Сгенерировать массив случайных чисел от 0 до 50
        int[] numbers = new int[10];
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 51);
        }

        // Подсчитать количество четных и нечетных чисел в массиве
        int evenCount = 0;
        int oddCount = 0;
        foreach (int number in numbers)
        {
            if (IsEven(number))
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        // Вывести массив чисел на экран
        Console.WriteLine("Массив чисел:");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }

        // Вывести количество четных и нечетных чисел на консоль
        Console.WriteLine();
        Console.WriteLine($"Четных чисел: {evenCount}");
        Console.WriteLine($"Нечетных чисел: {oddCount}");
    }

    // Функция для определения четности числа
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}