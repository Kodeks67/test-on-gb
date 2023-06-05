string[] NewArrayWithCondition(string[] array)
{
    

    string[] new_array = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i] != null)
        {
            newArray[i] += array[i];
            
        }
    }
    return newArray.Where(x => x != null).ToArray();
}

string GenerateStringElement()
{
    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*-_+={}|<>.,/?~`";

    var random = new Random();
    var stringChars = new char[random.Next(1, 8)];

    for (int i = 0; i < stringChars.Length; i++)
    {
        stringChars[i] = chars[random.Next(chars.Length)];
    }

    return new String(stringChars);
}

void FillArray(string[] elements)
{

    {
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = GenerateStringElement();
        }
    }
}

void PrintElement(string element)
{
    System.Console.Write($"\"{element}\"");
}

void PrintArray(string[] elements)
{
    System.Console.Write("[");
    for (int i = 0; i < elements.Length; i++)
    {
        if (i == elements.Length - 1)
            // System.Console.Write($"\"{elements[i]}\"");
            PrintElement(elements[i]);
        else
        {
            PrintElement(elements[i]);
            System.Console.Write($", ");
        }
    }
    System.Console.WriteLine("]");
}

void Task()
{
    int size = 10;
    string[] elements = new string[size];
    FillArray(elements);
    Console.WriteLine("Исходный массив:");
    PrintArray(elements);
    string[] resultArray = NewArrayWithCondition(elements);
    Console.WriteLine("Результирующий массив:");
    PrintArray(resultArray);


}
Task();
