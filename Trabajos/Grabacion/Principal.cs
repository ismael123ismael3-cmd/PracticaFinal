using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos.Grabacion
{
    internal class Principal
    {
        public static void Main(string[] args)
        {
            int OpcionContinuar;

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("SISTEMA DE RACIONAMIENTO - FORTIN NANAWA (Chaco 1933)");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");

            do
            {
                Console.WriteLine("--- REGISTRO DIARIO DE RECURSOS ---");
                Console.WriteLine("Ingresar la cantidad de comida disponible (en kilos)");

                Funcion.kilosDisponibles = int.Parse(Console.ReadLine());

                Funcion.CalcularRacionesComida();

                do
                {
                    Console.WriteLine("Desea Registrar el racionamiento del siguiente dia (1:Si/0:No)");
                    OpcionContinuar = int.Parse(Console.ReadLine());

                    if (OpcionContinuar != 0 && OpcionContinuar != 1) ;
                    {
                        Console.WriteLine("Opcion Invalida. Elija de nuevo");
                    }
                }
                while (OpcionContinuar != 0 && OpcionContinuar != 1);
            }
            while (OpcionContinuar != 0);
        }
    }
}
