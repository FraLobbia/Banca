using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // richiesta di cosa si vuole fare
            Console.WriteLine("Che cosa vuoi fare?");
            Console.WriteLine("\n1) Aprire un nuovo conto");
            Console.WriteLine("\n2) Prelevare");
            Console.WriteLine("\n3) Depositare");
            int risposta = Convert.ToInt16(Console.ReadLine());
           
            // check della risposta
            

            switch (risposta)
            {
                case 1:
                    // recupero dati per il costruttore
                    Console.WriteLine("\nInserisci il nome del proprietario del conto");
                    string proprietario = Console.ReadLine();
                    Console.WriteLine("\nQuanto vuoi depositare per aprire il conto?");
                    double primoDeposito = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\n");

                    // Creo il mio conto con i dati appena presi
                    ContoCorrente myConto = new ContoCorrente(proprietario, primoDeposito);

                    // gestisco output a seconda se il conto è stato aperto o meno
                    if (myConto.IsContoAperto())
                    {
                        myConto.msgWelcome();
                    }
                    else
                    {
                        Console.WriteLine("Il conto non è stato aperto.");
                    }
                    break;
               
                

                 

                      
            }
            
            Console.ReadLine();

        }

        
    }
}

 