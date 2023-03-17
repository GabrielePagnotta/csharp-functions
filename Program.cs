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

int Quadrato(int numero)
{
    var result = numero * numero ;
    return result;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] output = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        output[i] = Quadrato(array[i]);
    }

    return output;
}

int sommaElementiArray(int[] array)
{
    int sum = 0;  
    for (int i = 0; i < array.Length; i++)
    {
         sum += array[i];
    }
    return sum;
    
}


int[] array = {2,6,7,5,3,9};

//stampare l'array di numeri fornito a video
printArray(array);

//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])

int[] arraialquadrato = ElevaArrayAlQuadrato(array);

foreach (var elem in arraialquadrato)
{
    Console.WriteLine(elem);
}

//- *int sommaElementiArray(int[] array)*: che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

sommaElementiArray(array);
Console.WriteLine("la somma totale degli elementi dell'arrai è:");
Console.WriteLine(sommaElementiArray(array));

