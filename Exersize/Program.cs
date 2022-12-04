/*Написать программу, которая из имеющегося массива строк формирует массив строк, 
длина которых меньше либо равна 3 символам.*/

int[] InitArray(int n)
	{
	    int[] res = new int[n];
	    Random rnd = new Random();
	    for (int i = 0; i < n; i++)
	    {
	        res[i] = rnd.Next(-5000,5001);
	    }
	    return res;
	}

    void PrintArray(int[] array)
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

int[] ThreeSymbols(int[] array)
	{
        int[] result = new int[array.Length];
	   	    for (int i = 0; i < array.Length; i++)
	    {
	        if (array[i]>= -99 && array[i]<= 999) 
			  result[i] = array[i];
        }
	    return result;
	}


int n = GetNumber("Введите число элементов массива: ");
int[] array = InitArray(n);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Преобразованный массив: ");
int[] newarray = ThreeSymbols(array);
PrintArray(newarray);