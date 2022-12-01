void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;  
    }

}

void PrintArray(int[] petro)
{
    int count = petro.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(petro[position]);
        position++;
    }
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);


