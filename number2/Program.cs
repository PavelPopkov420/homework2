int n = Convert.ToInt32(Console.ReadLine());

if (n > 100 && n < 999)
{
    n = n % 10;
    Console.WriteLine("Третье чисто: " + Convert.ToString(n));
}
else 
    Console.WriteLine("Третьего числа нет");