void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));

}

string arrayToString(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}


int[] array = {2,6,7,5,3,9};

//stampare l'array di numeri fornito a video
printArray(array);  