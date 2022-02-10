//  Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 

int [] CreateArray (int n)
{
    int [] array = new int [n];
    for (int i = 0; i < n; i ++)
    {
            array [i] = new Random(). Next (1, 99);
    }
    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write ($"{array[i]} ");
        }
}

int [] ArrayEven (int [] newArray)
{
    int count = 0;
    int arrayLength = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
            if (newArray[i] % 2 == 0) arrayLength++;
        }

    int [] arrayEven = new int [arrayLength];

    for (int j = 0; j < newArray.Length; j++)
    {
        
        if (newArray[j] % 2 == 0) 
        {
            arrayEven[count] = newArray[j];
            count++;
        }
    }
    return arrayEven;
    
}

int [] arr = CreateArray(6);
ShowArray(arr);
Console.WriteLine();
int [] arrEven = ArrayEven (arr);
ShowArray (arrEven);
