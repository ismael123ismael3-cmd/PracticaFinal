using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos.Grabacion
{
    public class Funcion
    {
        public static int kilosDisponibles;

        public static void CalcularRacionesComida()
        {
            if (kilosDisponibles < 50)
            {
                Console.WriteLine("RACION DE EMERGENCIA:Solo se autoriza 1/4 de racion por soldado");
                Console.WriteLine("notificacion: Reservas en estado critico");
            }
            else if (kilosDisponibles <= 150)
            {
                Console.WriteLine("RACION REDUCIDA:Se autoriza media racion por soldado");
                Console.WriteLine("notificacion:Controlar el consumo diario consumo diario");
            }
            else
            {
                Console.WriteLine("RACION COMPLETA:Se autoriza racion normal para la tropa");
                Console.WriteLine("Norificacion:Suministros en buen estado");
            }
        }
    }

}
