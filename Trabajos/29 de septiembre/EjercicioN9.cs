using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN9
    {
        static unsafe void Main()
        {
            int* pCasillero =null;

            if (pCasillero== null)
            {
                Console.WriteLine("Todavía no tienes casillero asignado");
            }

            int casillero = 27;
            pCasillero =&casillero;

            if (pCasillero!=null)
            {
                Console.WriteLine("Tu casillero es el N.º " + *pCasillero);
            }
        }
    }
}