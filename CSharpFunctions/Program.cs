//BONUS: L'utente nella console deifinisce l'array al quale verranno applicate le funzioni definite in precedenza
//NB: Questo include non solo gli elemnti stessi dell'array, ma anche la lunghezza dell'array!

//Richiesta all'utente della lunghezza dell'array

Console.WriteLine("Quanti elementi conterrà l'array?");

//Sanificazione input dell'utente, in modo tale che vengano accettati solo numeri maggiori di 0

bool LengthSanification = false;
string StringUserLength = "";
int UserLength = 0;
do
{
    StringUserLength = Console.ReadLine();
    if (int.TryParse(StringUserLength, out UserLength) & UserLength > 0)            //Se l'input dell'utente è un numero(ed è maggiore di 0), verrà convertito correttamente
    {                                                                               //e il ciclo do while si interrompe
        LengthSanification = true;
        
        if (UserLength == 1)                                                        //Questo if viene usato nel caso l'utente decidesse di inserire soltanto un elemnto nell'array
        {                                                                           //così in questo caso viene stampato "elemntO", al posto di scrivre "elemento\i"
            Console.WriteLine("L'array avrà 1 elemento");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("L'array avrà " + UserLength + " elementi");
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Per favore inserisca un numero valido");                 //Altrimenti, se l'imput è invalido, il ciclo do while ricomnicia da capo, richiedendo l'imput
    }

} while (LengthSanification == false);

//Defininizione array vuoto, lungo tanto quanto richiesto dall'utente

int[] arrayInteri = new int[UserLength];

int element = 0;
string StringElement = "";

//Trasformazione dell'input dell'utente in elementi dell'array

for (int i = 0; i < arrayInteri.Length; i++)             
{
    bool ElementSanification = false;
    Console.WriteLine("Inserisca il " + (i + 1) + "º numero");

    //Sanificazione dell'input dell'utente
    do
    {
        StringElement = Console.ReadLine();
        if (int.TryParse(StringElement, out element))                                   //Se l'input dell'utente è un numero(ed è maggiore di 0), verrà convertito correttamente
        {                                                                               //e il ciclo do while si interrompe
            ElementSanification = true;
            arrayInteri[i] = element;                                                   //Solo se l'utente ha imesso un numero intero esso verrà aggiunto all'array
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Per favore inserisca un numero valido");                 //Altrimenti, se l'imput è invalido, il ciclo do while ricomnicia da capo, richiedendo l'imput
            Console.WriteLine();
        }

    } while (ElementSanification == false);
}

//Prova della funzione 1 (Stampa dell'array a video)
Console.WriteLine("L'array da lei scelto risulta:");
StampaArrayInteri(arrayInteri);
Console.WriteLine();

//Prova della funzione 3 (Stampa dell'array in cui i numeri sono stati elevati al quadrato)
Console.WriteLine("Se eleviamo al quadrato ogni singolo numero otteniamo l'array:");
StampaArrayInteri(ElevaArrayAlQuadrato(arrayInteri));
Console.WriteLine();

//Prova della funzione 4 (Stampa della somma di tutti i numeri)
int sum = sommaElementiArray(arrayInteri);
Console.WriteLine("La somma di tutti gli elementi dell'array risulta: " + sum);
Console.WriteLine();

//Stampa della somma di tutti i numeri elevati ai quadrati
int sum_2 = sommaElementiArray(ElevaArrayAlQuadrato(arrayInteri));                                          
Console.WriteLine("La somma di tutti gli elementi dell'array, dopo averli elevati al quadrato, risulta: "+ sum_2);               


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