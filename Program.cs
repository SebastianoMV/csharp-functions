// See https://aka.ms/new-console-template for more information

int numeroUtente;
Console.WriteLine("Quanti numeri vuoi inserire?");
numeroUtente = Int32.Parse(Console.ReadLine());
int[] arrayNumeri = new int [numeroUtente];
for (int i = 0; i < numeroUtente; i++)
{
    Console.WriteLine("Inserisci il " + (i +1) + "numero");
    arrayNumeri[i] = Int32.Parse(Console.ReadLine());

}

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

StampaArray(ElevaArrayAlQuadrato(arrayNumeri));
Console.WriteLine("Array originale:");
StampaArray(arrayNumeri);

Console.WriteLine(" ");
Console.WriteLine("Somma dei numeri:");
Console.WriteLine(sommaElementiArray(arrayNumeri));

Console.WriteLine(" ");
Console.WriteLine("Somma dei numeri a potenza:");
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(arrayNumeri)));