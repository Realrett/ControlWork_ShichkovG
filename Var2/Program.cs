string[] InitArray(int n)
{
	{
	    string[] res = new string[n];
	    Random rnd = new Random();
	    for (int i = 0; i < res.Length; i++)
	    {
	        res[i] = ((int)rnd.Next(-1500, 1500)).ToString();
	    }
	    return res;
	}
}
   
       void PrintArray(string[] array)
	{
	    for (int i = 0; i < array.Length; i++)
	    {
	        Console.Write($"{array[i]} ");
	    }
	    Console.WriteLine();
	}

    int GetNumber(string message)
{
Console.WriteLine(message);
int result = int.Parse(Console.ReadLine());
return result;
}

string[] ThreeSymbols(string[] array)
	{
            string[] result = new string[array.Length];
        
	   	    for (int i = 0; i < array.Length; i++)
	    {
	        if (array[i].Length <= 3) 
               result[i] = array[i];       
        }
	    return result;
	}

int n = GetNumber("Введите число элементов массива: ");
string[] array = InitArray(n);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Преобразованный массив: ");
string[] newarray = ThreeSymbols(array);
PrintArray(newarray);