using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN20
    {
        static unsafe void Copiar(int* origen, int* destino, int n)
        {
            for (int i = 0; i < n; i++)
            {

                *(destino + i)
                 = *(origen + i);
            }
        }

        static unsafe void Main()
        {
            int[] ejemplares = { 12, 8, 15, 6, 10 };
            int[] disponibles = new int[5];
            int[] prestados = { 5, 3, 9, 2, 4 };

            fixed (int* pEje = ejemplares, pDis = disponibles, pPre = prestados)
            {
                Copiar(pEje,pDis, ejemplares.Length);
                int* masPedido = pPre;
                int totalPrestados = 0;

                for (int i = 0; i < ejemplares.Length; i++)
                {
                    pDis[i]-= pPre[i];
                    totalPrestados += *(pPre + i);
                    if (*(pPre + i) >*masPedido)
                    {
                        masPedido = pPre + i;
                    }
                }

                Console.WriteLine("Libro | Ejemplares | Disponibles");
                for (int i = 0; i < ejemplares.Length; i++)
                {
                    Console.WriteLine("  " + (i + 1) + "   |     " + pEje[i] + "     |     " + pDis[i]);
                }
                Console.WriteLine("Libros prestados en total: " + totalPrestados);
                Console.WriteLine("Libro más pedido: N.º " + (masPedido - pPre + 1));
            }
        }
    }
}