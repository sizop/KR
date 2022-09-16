Console.WriteLine("Максимальное количество символов в элементе массива: ");
int symbol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество элементов массива: ");
int element = Convert.ToInt32(Console.ReadLine());
string [] GetArray (int m, int n) // метод ввода массива 
{
	string[] Array = new string[n];
	int stringlen = new Random().Next(1, m), randValue;
	char letter;
	for (int k = 0; k < n; k++)
	{
		string str = ""; stringlen = new Random().Next(1, m);
		for (int i = 0; i < stringlen + 1; i++)
		{
			randValue = new Random().Next(26);
			letter = Convert.ToChar(randValue + 65);
			str = str + letter;
		}
		Array[k] = str;
	}
	return Array;
}
string[] matrix = GetArray(symbol, element);
Console.Write("\n" + "Исходный массив: " + "\n");
Console.WriteLine(String.Join(",", matrix));
string[] matrixOut = new string[element];
for (int i = 0; i < element; i++)
{
	if (matrix[i].Length <= 3) matrixOut[i] = matrix[i];
	else matrixOut[i] = "";
}
Console.Write("\n" + "Элементы массива с количеством символов <=3: " + "\n");
var result = matrixOut.Where(x => !string.IsNullOrWhiteSpace(x));
Console.WriteLine(String.Join(",", result));
