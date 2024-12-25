static void Factorial(int n)
{
    long factorial = 1;

    if (n == 1 || n == 0)
    {
        Console.WriteLine($"El factorial de {n} es 1 ");
        return;
    }

    for (int i = 1; i <= n; i++)
        factorial *= i;

    Console.WriteLine($"El factorial de {n} es {factorial} ");
    return;
}

static void SumaImpares(int n)
{
    int sum = 0;

    for (int i = 1; i <= n; i = i + 2)
        sum += i;

    Console.WriteLine(sum);
}

static void Perezoso()
{
    Console.WriteLine("Escribe numeros para determinar varias cosas de todos ellos: ");
    string number = Console.ReadLine();
    int mayor = int.Parse(number);
    int menor = int.Parse(number);
    int sum = 0, count = 0;

    while (number != "")
    {
        int entero = int.Parse(number);

        sum += entero;
        count++;

        if (mayor < entero) mayor = entero;
        if (menor > entero) menor = entero;

        number = Console.ReadLine();
    }

    double promedio = sum / count;

    Console.WriteLine($"El menor numero que introduciste fue: {menor} ");
    Console.WriteLine($"El mayor numero que introduciste fue: {mayor} ");
    Console.WriteLine($"El promedio de los numeros es: {promedio}");
}

static int MayorDelArray(int[] array)
{
    int max = array[0];

    for (int i = 1; i < array.Length; i++)
        if (max < array[i])
            max = array[i];

    return max;
}

static int SegundoMenor(int[] array)
{
    int segundoMenor;

    if (array[0] != Tools.MenorDelArray(array))
        segundoMenor = array[0];

    else segundoMenor = array[1];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == Tools.MenorDelArray(array))
            continue;

        else if (segundoMenor > array[i])
            segundoMenor = array[i];
    }

    return segundoMenor;
}

static bool Pertenecer(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == n) return true;

    return false;
}

static double Promedio(int[] array)
{
    double promedio, sum = 0;

    for (int i = 0; i < array.Length; i++)
        sum += array[i];

    promedio = sum / array.Length;

    return promedio;
}

static List<int> MayorAlPromedio(int[] array)
{
    double promedio = Promedio(array);

    List<int> mayorAlPromedio = []; // Esto es lo mismo que new() o new List<int>();

    for (int i = 0; i < array.Length; i++)
        if (array[i] > promedio)
            mayorAlPromedio.Add(array[i]);

    return mayorAlPromedio;
}

static void InvertirArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
        Tools.Swap(array, i, array.Length - 1 - i);
}

static void FiltrandoPositivo(int[] array)
{
    List<int> positivo = []; // Esto es lo mismo que new() o new List<int>();

    for (int i = 0; i < array.Length; i++)
        if (array[i] >= 0)
            positivo.Add(array[i]);

    array = [.. positivo]; //Es lo mismo que hacer positivo.ToArray();
}

static void RotarArray(int[] array, int veces)
{
    int longitud = array.Length;
    if (veces % longitud == 0) return;

    veces = ((veces % longitud) + longitud) % longitud;  //Esto es lo mismo que veces += array.Length o veces = veces + array.Lenth

    for (int i = 0; i < veces; i++)
        Tools.Rotar(array);
}

static int[] MezclaOrdenada(int[] array1, int[] array2)
{
    int count = 0;
    int[] mezclaOrdenada = new int[array1.Length + array2.Length];
    int i = 0, j = 0;

    while (i < array1.Length && j < array2.Length)
    {
        if (array1[i] < array2[j])
        {
            mezclaOrdenada[count] = array1[i];
            i++;
        }

        else
        {
            mezclaOrdenada[count] = array2[j];
            j++;
        }

        count++;
    }

    while (i < array1.Length)
    {
        mezclaOrdenada[count] = array1[i];
        i++;
        count++;
    }

    while (j < array1.Length)
    {
        mezclaOrdenada[count] = array2[j];
        j++;
        count++;
    }

    return mezclaOrdenada;
}

int[] AgregarAlFinal(int[] array, int val)
{
    int[] nuevoArray = Tools.AumentarArray(array);

    nuevoArray[^1] = val;

    return nuevoArray;
}

static int[] Insertar(int[] array, int pos, int val)
{
    int[] desplazarPosiciones = new int[array.Length + 1];

    for (int i = 0; i < desplazarPosiciones.Length; i++)
    {
        if (i < pos)
            desplazarPosiciones[i] = array[i];

        else if (i > pos)
            desplazarPosiciones[i] = array[i - 1];

        else
            desplazarPosiciones[i] = val;
    }

    return desplazarPosiciones;
}

static int[] Eliminar(int[] array, int pos)
{
    int[] eliminar = new int[array.Length - 1];

    for (int i = 0; i < eliminar.Length; i++)
    {
        if (i < pos)
            eliminar[i] = array[i];

        else
            eliminar[i] = array[i + 1];
    }

    return eliminar;
}

static string RepresentacionBinario(int number)
{
    string binario = "";

    while (number / 2 != 0)
    {
        binario = (number % 2).ToString() + binario;
        number /= 2;
    }

    if (number / 2 == 0) binario = "1" + binario;

    return binario;
}

static int RepresentacionEntero(string binario)
{
    int entero = 0, count = 0;

    for (int i = binario.Length - 1; i >= 0; i--)
    {
        entero += (binario[i] - '0') * (int)Math.Pow(2, count);
        count++;
    }

    return entero;
}

static bool EsPrimo(int number)
{
    if (number <= 1) return false;

    if (number == 2 || number == 3) return true;

    if (number % 2 == 0) return false;

    for (int i = 3; i < (int)Math.Sqrt(number); i += 2)
        if (number % i == 0) return false;

    return true;
}

static bool NumeroPerfecto(int number)
{
    int sumaAcumulada = 0;

    for (int i = 2; i < Math.Sqrt(number); i++)
        sumaAcumulada += Tools.BuscandoDivisor(number, i);

    sumaAcumulada += 1;

    if (sumaAcumulada == number) return true;

    return false;
}

static bool Substring(string cadena, string subcadena)
{
    if (string.IsNullOrEmpty(subcadena)) return true;

    if (string.IsNullOrEmpty(cadena)) return false;

    int longitudCadena = cadena.Length, longitudSubcadena = subcadena.Length;

    for (int i = 0; i < longitudCadena - longitudSubcadena; i++)
    {
        bool encontrada = true;

        for (int j = 0; j < longitudSubcadena; j++)
            if (cadena[i + j] != subcadena[j])
            {
                encontrada = false;
                break;
            }

        if (encontrada) return true;
    }

    return false;
}

static bool Palindromo(string palindromo)
{
    for (int i = 0; i < palindromo.Length / 2; i++)
        if (palindromo[i] != palindromo[palindromo.Length - 1 - i]) return false;

    return true;
}

static string MenorSufijoParaSerPalindromo(string cadena)
{
    if (Palindromo(cadena) || cadena == "" || cadena.Length == 1) return "";

    string revertida = Tools.RevertirCadena(cadena);

    for (int i = 0; i < cadena.Length; i++)
        if (cadena.Substring(i) == revertida.Substring(0, cadena.Length - i))
            return revertida.Substring(cadena.Length - i);

    return revertida.Substring(1);
}

static void Ordenar(int[] array)
{
    if (array == null || array.Length == 0 || array.Length == 1) return;

    bool bandera = true;

    for (int i = 0; i < array.Length - 1 && bandera; i++)
    {
        bandera = false;

        for (int j = 0; j < array.Length - 1 - i; j++)
            if (array[j] > array[j + 1])
            {
                Tools.Swap(array, j, j + 1);
                bandera = true;
            }
    }
}

static int Mediana(int[] array)
{
    Ordenar(array);

    return array[array.Length / 2];
}

//Complete