 Console.WriteLine("Введите пятизначное число: ");
 int num1 = int.Parse(Console.ReadLine());
 int f1 = num1 / 10000;
 int f2 = (num1 - f1 * 10000) / 1000;
 int r1 = num1 % 10;
 int r2 = (num1 % 100) / 10;
 if(10000 > num1 || num1 > 99999)
 {
    Console.Write("Введено не пятизначное число");
 }
    else if(f1 == r1 && f2 == r2)
    {
        Console.Write("Палиндром");
    }
    else
    {
        Console.Write("Не палиндром");
    }