/*Написать программу, которая из имеющегося массива строк формирует массив строк, 
длина которых меньше либо равна 3 символам.*/

int[] InitArray()
	{
	    int[] res = new int[10];
	    Random rnd = new Random();
	    for (int i = 0; i < res.Length; i++)
	    {
	        res[i] = rnd.Next(0,100);
	    }
	    return res;
	}
