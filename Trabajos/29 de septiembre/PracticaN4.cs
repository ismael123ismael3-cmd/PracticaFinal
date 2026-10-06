using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class PracticaN4
    {
        static unsafe void Main()
        {
            {
                int vaquita = 100;
                int* pAna = &vaquita;
                int* pLuis = pAna;


                *pAna += 30;

                *pLuis -= 45;

                Console.WriteLine("Ana aportó 30 Bs y Luis gastó 45 Bs");
                Console.WriteLine("Queda en la vaquita: " + vaquita + " Bs");
                Console.WriteLine("¿Apuntan al mismo lugar? " + (pAna == pLuis));

            }
        }
    }
}
