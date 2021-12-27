// **Задача**: 
// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(int[] newarray)
{
    for (int i = 0; i < newarray.Length; i++)
    {
        newarray[i] = new Random().Next(1, 20);
    }
}

void PrintArray(int[] newarray)
{
    for (int i = 0; i < newarray.Length; i++)
    {
        Console.Write($"{newarray[i]} ");
    }
}

int newarraysize(int[] array)
{
    int targetarraylength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 8)
        {
            targetarraylength++;
        }
    }
    return targetarraylength;
}

void Fillg8array(int[] newarray, int [] targetarray)
{
    for (int j = 0, k = 0; j < newarray.Length; j++)
    {
        if (newarray[j] > 8)
        {
            targetarray[k] = newarray[j];
            k++;
        }
    }
}

void Demo ()
{
    int arraylength = 10;
    int[] sourcearray = new int[arraylength];
    FillArray(sourcearray);
    PrintArray(sourcearray);
    Console.WriteLine("");
    int[] targetarray = new int [newarraysize(sourcearray)];
    Fillg8array (sourcearray, targetarray);

    PrintArray(targetarray);
}

Demo ();
