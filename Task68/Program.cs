//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int m = GetNumberFromUser("Введите первое натуральное число: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите второе натуральное число: ", "Ошибка ввода!");

Console.WriteLine($"m={m}, n = {n}. A(m,n)={AkkermanFunc(m, n)}");


// Запрашивает у пользователя целое положительное число
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >= 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}

int AkkermanFunc(int m, int n)
{
    if (m == 0) return n+1;
    else if (m>0 && n==0) return AkkermanFunc(m - 1, 1);
    else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}