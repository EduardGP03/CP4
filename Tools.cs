class Tools
{
    public static int MenorDelArray(int[] array)
    {
        int menor = array[0];

        for (int i = 1; i < array.Length; i++)
            if (menor > array[i])
                menor = array[i];

        return menor;
    }
    public static void Swap(int[] array, int left, int right)
    {
        (array[left], array[right]) = (array[right], array[left]);
    }
    public static void Rotar(int[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
            Swap(array, i, i - 1);
    }
    public static int[] AumentarArray(int[] array)
    {
        int[] aumentarArray = new int[array.Length + 1];
        Array.Copy(array, aumentarArray, array.Length);

        return aumentarArray;
    }
    public static int BuscandoDivisor(int number, int divisor)
{
    int sumaAcumulada = 0;

    if (number % divisor == 0)
    {
        sumaAcumulada += divisor + number / divisor;
    }

    return sumaAcumulada;
}
    public static string RevertirCadena(string cadena)
    {
        char[] cadenaChars = cadena.ToCharArray();
        Array.Reverse(cadenaChars);
        return new string(cadenaChars);
    }
    


    
}