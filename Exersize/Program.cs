/*Написать программу, которая из имеющегося массива строк формирует массив строк, 
длина которых меньше либо равна 3 символам.*/

int[] InitArray()
	{
	    int[] res = new int[n];
	    Random rnd = new Random();
	    for (int i = 0; i < n; i++)
	    {
	        res[i] = rnd.Next(-10000,10001);
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

    
