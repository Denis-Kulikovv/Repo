int[] array = {12, 22, 36, 45, 57, 62, 12, 75, 84};

int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1
    index++;
};