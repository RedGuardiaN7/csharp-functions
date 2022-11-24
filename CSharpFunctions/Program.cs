//CONSEGNA: Definire le funzioni di utilità.

//Funzione 1: void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array

//Defininizione array di interi
int[] arrayInteri = { 1, 5, 6, 9, 1, 2, 3 };

StampaArrayInteri(arrayInteri);             //Prova della funzione 1




//------------------Definizione delle funzioni-----------------

//Funzione 1: void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array
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
