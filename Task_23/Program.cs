Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count<=N; count++) {
	double result = Math.Pow(count, 3);
	Console.WriteLine(result);
}
