int n = Convert.ToInt32(Console.ReadLine());

if (n > 100 && n < 999)
    {
    n = (n / 10) % 10;
    Console.WriteLine("Второе чисто: " + Convert.ToString(n));
    }
else
    Console.WriteLine("Введите трехзначное число: ");