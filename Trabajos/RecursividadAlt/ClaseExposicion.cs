using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos.RecursividadAlt
{
    public class ClaseExposicion
    {
        static long pasos = 0;   // contador de operaciones


        static bool Cond(bool resultado)
        {
            pasos++;
            return resultado;
        }


        static void MostrarPrecios(double[] precios)
        {
            for (int i = 0; Cond(i < precios.Length); i++)
            { Console.WriteLine($"Bs {precios[i]}"); pasos++; }
        }


        static long MiFormula(long n)
        {
            return ;
        }

        static void Main(string[] args)
        {
            var consola = Console.Out;
            Console.WriteLine("    n | pasos | tu T(n) | ¿coincide?");
            foreach (int n in new[] { 1, 2, 3, 10 })
            {
                double[] precios = new double[n];
                pasos = 0;
                Console.SetOut(TextWriter.Null);
                MostrarPrecios(precios);
                Console.SetOut(consola);
                long tuyo = MiFormula(n);
                string ok = tuyo == pasos ? "sí" : "NO";
                Console.WriteLine($"{n,5} | {pasos,5} | {tuyo,7} | {ok}");
            }
        }
    }
}
    
