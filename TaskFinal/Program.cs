string [] textArray = {"final", "work", "for", "geek", "brains", "!"};

void ShowArray (string [] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
            if (i == (array.Length - 1))  Console.Write ($"{array[i]}");
            else Console.Write ($"{array[i]}, ");
            
        }
         Console.Write(" ]");
}

string [] StringArrayFromSomeSumbols (string [] array)
{
    int count = 0;
    int arrayLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i].Length <= 3) arrayLength++;
        }

    string [] arrayString = new string [arrayLength];

    for (int j = 0; j < array.Length; j++)
    {
        
        if (array[j].Length <= 3) 
        {
            arrayString[count] = array[j];
            count++;
        }
    }
    return arrayString;
    
}

ShowArray(textArray);
Console.Write (" -> ");
string [] newTextArray = StringArrayFromSomeSumbols (textArray);
ShowArray(newTextArray);