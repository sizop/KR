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
for (int j = 0; j < matrix.GetLength(0); j++)
{ Console.Write(matrix[j] + "\t"); }
string[] matrixOut = new string[element];
for (int i = 0; i < element; i++)
{
	if (matrix[i].Length <= 3) matrixOut[i] = matrix[i];
	else matrixOut[i] = "";
}
Console.Write("\n" + "Элементы массива с количеством символов <=3: " + "\n");
for (int j = 0; j < matrixOut.GetLength(0); j++)
{
	if (matrixOut[j] != "") Console.Write(matrixOut[j] + "\t");
}