// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


int Ack(int n, int m)
{
    if (n == 0)
        return m + 1;

    if (m == 0)
        return Ack(n - 1, 1);

    return Ack(n - 1, Ack(n, m - 1));
}


Console.Write("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int result = Ack(n, m);
        Console.WriteLine($"Результат функции Аккермана Ack({n}, {m}) = {result}");

