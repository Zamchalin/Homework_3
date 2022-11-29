Console.Clear();
Console.Write("Ведите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if( n < 10000 || n > 100000)
    Console.Write("Это не пятизначное число");
else if( n % 10 == (n / 10000) % 10 && (n / 1000 % 10) == (n / 10) % 10)
    Console.Write("Это число - палиндром");
else 
    Console.Write("Это число не палиндром");