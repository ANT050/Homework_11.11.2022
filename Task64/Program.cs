/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> [5, 4, 3, 2, 1]
N = 8 -> [8, 7, 6, 5, 4, 3, 2, 1]*/

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

//Нахождение натуральных чисел в промежутке от N до 1
string AllNaturalValues(int number)
{
	if (number <=0)
		throw new Exception($"\nПроверьте правильность ввода, числа должны быть натуральным!");

	if (number <= 1)
		return number.ToString();
	else
	{
		return number + "," + AllNaturalValues(number - 1);
	}
}

try
{
int value = EnteringValue("\nВведите число N: ");
Console.WriteLine($"N = {value} -> [{AllNaturalValues(value)}]");
}

catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
