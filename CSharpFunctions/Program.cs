//CONSEGNA: Definire le funzioni di utilità.

//Defininizione array di interi
int[] arrayInteri = { 2, 6, 7, 5, 3, 9};

StampaArrayInteri(arrayInteri);                                 //Prova della funzione 1 (Stampa dell'array a video)

StampaArrayInteri(ElevaArrayAlQuadrato(arrayInteri));           //Prova della funzione 3 (Stampa dell'array in cui i numeri sono stati elevati al quadrato)

Console.WriteLine(sommaElementiArray(arrayInteri));             //Prova della funzione 4 (Stampa della somma di tutti i numeri

Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(arrayInteri)));               //Stampa della somma di tutti i numeri elevati ai quadrati


//------------------Definizione delle funzioni-----------------

//Funzione 1: void StampaArrayInteri(int[] array), che preso un array di numeri interi, stampa a video il contenuto dell’array
void StampaArrayInteri(int[] array)
{
    string content = "";

    for (int i = 0; i < array.Length; i++)
    {
        
        if (i == array.Length - 1)
        {
            content += "\"" + array[i] + "\"";
        }
        else
        {
            content += "\"" + array[i] + "\", ";
        }
    }

    Console.WriteLine("[ " + content + "]");
}

//Funzione 2: int Quadrato(int numero), che restituisca il quadrato del numero passato come parametro

int Quadrato(int number)
{
    int result = number * number;
    return result;
}

//Funzione 3: int[] ElevaArrayAlQuadrato(int[] array), che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] CopyArray = (int[])array.Clone();

for (int i = 0; i < CopyArray.Length; i++)
{
    CopyArray[i] = Quadrato(CopyArray[i]);
    }
    return CopyArray;
}

//Funzione 4: int sommaElementiArray(int[] array), che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array

int sommaElementiArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}