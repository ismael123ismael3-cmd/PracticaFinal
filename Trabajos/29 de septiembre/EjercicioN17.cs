using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN17
    {
        static unsafe void Main()
        {
            string sigla = "UNICEN";
            int vocales = 0, letras = 0;

            fixed (char* p = sigla)
            {
                char* c = p;
                while (*c!= '\0')
                {
                    if (*c == 'A'|| *c == 'E' || *c == 'I' || *c == 'O' || *c == 'U')
                    {
                        vocales++;
                    }
                    letras++;

                    c++
                    ;
                }
            }

            Console.WriteLine("Sigla: " + sigla);
            Console.WriteLine("Letras: " + letras + " | Vocales: " + vocales + " | Consonantes: " + (letras - vocales));
        }
    }
}