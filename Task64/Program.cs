// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int N = GetNumberFromUser("Введите натуральное число: ", "Ошибка ввода!");
Console.WriteLine($"N = {N} -> {GetNumbers(1, N)}");

// Запрашивает у пользователя целое положительное число
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 1)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}

//нахождение натуральных чисел от N до 1
string GetNumbers(int start, int N)
{
    if (start == N)
        return N.ToString();
    else
        return N + " " + GetNumbers(start, --N);
}
