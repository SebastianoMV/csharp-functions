// See https://aka.ms/new-console-template for more information

int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };


void StampaArray(int[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
        if (i < (array.Length -1 )) Console.Write('\u002C');
    }
    Console.WriteLine(']');
};


int Quadrato(int numero)
{
    return (numero * numero);
};


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] nuvoArray;
    nuvoArray = (int[])array.Clone();

    for (int i = 0; i < nuvoArray.Length; i++)
    {
        nuvoArray[i] = Quadrato(nuvoArray[i]);
    }
    return nuvoArray;
}


int sommaElementiArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum; 

};

StampaArray(arrayNumeri);