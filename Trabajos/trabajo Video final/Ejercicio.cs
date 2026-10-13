using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos.trabajo_Video_final
{
    public class Ejercicio
    {
        public static void Main(string[] args)
        {
            int opcionContinuar;

            Console.WriteLine("=========================================================");
            Console.WriteLine(" SISTEMA DE RACIONAMIENTO - FORTÍN NANAWA (CHACO 1933)   ");
            Console.WriteLine("=========================================================");

            do
            {
                Console.WriteLine("\n--- REGISTRO DIARIO DE RECURSOS ---");
                Console.Write("Ingrese la cantidad de comida disponible (en kilos): ");

                // Guardamos la lectura directamente en la variable de la clase
                funcion1.kilosDisponibles = int.Parse(Console.ReadLine());

                // Llamada a la función con paréntesis VACÍOS ()
                funcion1.CalcularRacionComida();

                do
                {
                    Console.Write("\n¿Desea registrar el racionamiento del siguiente día? (1: Sí / 0: No): ");
                    opcionContinuar = int.Parse(Console.ReadLine());

                    if (opcionContinuar != 0 && opcionContinuar != 1)
                    {
                        Console.WriteLine("Opción inválida. Elija de nuevo.");
                    }
                } while (opcionContinuar != 0 && opcionContinuar != 1);

            } while (opcionContinuar != 0);

        }
    }
}