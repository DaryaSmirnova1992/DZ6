Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int katet1 = (x1 - x2);
int katet2 = (y1 - y2);
double hypotenuse = Math.Sqrt(Math.Pow(katet1,2) + Math.Pow(katet2,2));
int katet3 = (z1 - z2);
double hypotenuse2 = Math.Sqrt(Math.Pow(hypotenuse,2) + Math.Pow(katet3,2));
Console.Write(hypotenuse2);