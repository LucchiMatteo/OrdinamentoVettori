using System;

namespace OrdinamentoVettori
{//commento di prova
    class Program
    {//commento
        static void Main(string[] args)
        {
            //Crezione e popolamento del vettori di interi
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18};

            //Invoco il metodo per l'ordinamento
            ordina(vettore);

            //Stampo a video il contenuto del vettore
            for (int i = 0; i < 10; i++)
                Console.WriteLine(vettore[i]);

            Console.ReadKey();
        }

        //Metodeo per l'ordinamento
        static void ordina (int[] vettore)
        {
            Array.Sort(vettore);
        }

     
    }
}
