using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos.trabajo_Video_final
{
    public class funcion1
    {
        public static int kilosDisponibles;
        public static void CalcularRacionComida()
        {

            if (kilosDisponibles < 50)
            {
                Console.WriteLine("--> RACIÓN DE EMERGENCIA: Solo se autoriza 1/4 de ración por soldado.");
                Console.WriteLine("    Notificación: Reservas en estado crítico.");
            }
            else if (kilosDisponibles <= 150)
            {
                Console.WriteLine("--> [RACIÓN REDUCIDA]: Se autoriza media ración por soldado.");
                Console.WriteLine("    Notificación: Controlar el consumo diario.");
            }
            else
            {
                Console.WriteLine("--> [RACIÓN COMPLETA]: Se autoriza ración normal para la tropa.");
                Console.WriteLine("    Notificación: Suministro en buen estado.");
            }
        // FUNCION 2: Gestiona el ciclo diario de registro y la interacción con el usuario
        }
    }
}