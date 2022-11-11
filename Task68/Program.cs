/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

// Ввод значения, проверка на правильность ввода
int EnteringValue(string message)
{
	int result = 0;
	bool isCorrect = false;

	while (!isCorrect)
	{
		Console.Write(message);
		isCorrect = int.TryParse(Console.ReadLine(), out result);

		if (!isCorrect)
			Console.WriteLine("\nВведите корректное число!\n");
	}
	return result;
}

//Функция Аккермана
int AckermannFunktion(int m, int n)
{
	if (n < 0 | m < 0)
		throw new Exception($"\nПроверьте правильность ввода, числа должны быть не отрицательные!");

	if (m == 0)
		return n + 1;
	else if ((m > 0) && (n == 0))
		return AckermannFunktion(m - 1, 1);
	else
		return AckermannFunktion(m - 1, AckermannFunktion(m, n - 1));
}

try
{
int m = EnteringValue("\nВведите число m: ");
int n = EnteringValue("Введите число n: ");
Console.WriteLine($"\nm = {m}, n = {n} -> A(m,n) = {AckermannFunktion(m, n)}");
}

catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
