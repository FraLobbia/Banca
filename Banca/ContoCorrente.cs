using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    internal class ContoCorrente
    {
        //proprietà
        public string Proprietario { get; set; }
        public double Saldo { get; set; }
        
        //costruttore
        public ContoCorrente(string proprietario, double saldo)
        {
            if (saldo > 999)
            {
                Proprietario = proprietario;
                Saldo = saldo;
            } 
            else
            {
                Console.WriteLine("Devi caricare più di 1000\n");
            }
            
            
        }

        // metodi
        public double getSaldo() { return Saldo; }
        public void handlePrelievo(double qnt) { Saldo = Saldo - qnt ; }
        public void handleDeposito(double qnt) { Saldo = Saldo + qnt; }
        public void msgWelcome() 
        {
            Console.WriteLine("Congratulazioni, hai aperto con successo il conto di " + Proprietario + " ed hai depositato "+ Saldo);
        }
        public bool IsContoAperto()
        {
            return Saldo > 0;
        }
    }
}
