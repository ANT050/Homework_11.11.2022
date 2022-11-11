/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

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

//Нахождение суммы натуральных элементов в промежутке от M до N
int SumOfNaturalElements(int m, int n)
{
	if (m <= 0 & n < 0)
		throw new Exception($"\nОтсутствуют натуральные элементы");
		
	if (m < 0) m = 0;
	if (n < m) (m, n) = (n, m);
	if (m == n) return m;
	else return n + SumOfNaturalElements(m, n - 1);
}

try
{
	int valueM = EnteringValue("\nВведите число M: ");
	int valueN = EnteringValue("Введите число N: ");
	Console.WriteLine($"\nСумму натуральных элементов в промежутке от {valueM} до {valueN} = {SumOfNaturalElements(valueM, valueN)}");
}

catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
