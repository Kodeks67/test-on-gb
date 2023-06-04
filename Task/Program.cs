string[] NewArrayWithCondition(string[] array)
{
    // int new_size = 0;

    string[] new_array = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i] != null)
        {
           new_array[i] += array[i];
            // new_size++;
        }
    }
    return new_array.Where(x => x != null).ToArray();
}

