using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class PracticaN2
    {
        static unsafe void Main()
        {
            int saldo = 20;
            int* pSaldo = &saldo;

            Console.WriteLine("Saldo inicial:           " + saldo + " Bs");
            *pSaldo= *pSaldo - 6;
            Console.WriteLine("Tras imprimir apuntes:   " + saldo + " Bs");
            *pSaldo -= 4;
            Console.WriteLine("Tras imprimir la práctica: " + saldo + " Bs");
        }
    }
}
