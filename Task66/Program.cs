//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();
int M = GetNumberFromUser("Введите первое натуральное число: ", "Ошибка ввода!");
int N = GetNumberFromUser("Введите второе натуральное число: ", "Ошибка ввода!");
if (M > N)
{
    int temp = M;
    M = N;
    N = temp;
}
Console.WriteLine($"M={M}, N = {N}. Сумма чисел равна {GetNumbers(M, N)}");


// Запрашивает у пользователя целое положительное число
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}


//Вычисляет сумму натуральных чисел от M до N
int GetNumbers(int M, int N)
{
    if (M == N)
        return M;
    else return M + GetNumbers(M + 1, N);
}