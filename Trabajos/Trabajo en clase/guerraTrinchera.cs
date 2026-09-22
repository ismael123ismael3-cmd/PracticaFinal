using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Trabajos.Trabajo_en_clase
{
    public class Character
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }
        public int Morale { get; set; } // Representa la moral o estado de ánimo del personaje/tropas

        public Character(string name, string rank, string description, int morale)
        {
            Name = name;
            Rank = rank;
            Description = description;
            Morale = morale;
        }

        public void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Program.TypewriterWrite($"\n-- Personaje: {Name} --", 30);
            Console.ResetColor();
            Program.TypewriterWrite($"Rango: {Rank}", 20);
            Program.TypewriterWrite($"Descripción: {Description}", 20);
            Program.TypewriterWrite($"Moral Actual: {Morale}\n", 20);
        }

        public void AdjustMorale(int amount)
        {
            Morale += amount;
            if (Morale < 0) Morale = 0; // La moral no puede ser negativa
            if (Morale > 100) Morale = 100; // La moral no puede exceder 100
            Console.ForegroundColor = ConsoleColor.Yellow;
            Program.TypewriterWrite($"Moral de {Name} ajustada en {amount}. Moral actual: {Morale}", 25);
            Console.ResetColor();
            Thread.Sleep(500);
        }
    }

    // Definimos una clase para representar un evento en la guerra de trincheras
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public List<string> InvolvedCharacters { get; set; }
        public Action<Character>? OnExecute { get; set; } // Acción a ejecutar cuando ocurre el evento

        public Event(string name, string description, DateTime date, List<string> involvedCharacters, Action<Character>? onExecute = null)
        {
            Name = name;
            Description = description;
            Date = date;
            InvolvedCharacters = involvedCharacters;
            OnExecute = onExecute;
        }

        public void DisplayEvent()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Program.TypewriterWrite($"\n-- Evento: {Name} --", 30);
            Console.ResetColor();
            Program.TypewriterWrite($"Fecha: {Date.ToShortDateString()}", 20);
            Program.TypewriterWrite($"Descripción: {Description}", 20);
            Program.TypewriterWrite("Personajes involucrados: " + string.Join(", ", InvolvedCharacters) + "\n", 20);
        }
    }

    public class Program
    {
        // --- Variables de juego (globales o pasadas entre funciones) ---
        static Character generalHanscunt = new Character(
            "General Hanscunt",
            "General de División",
            "Un estratega veterano de la Gran Guerra, conocido por su tenacidad en las trincheras.",
            80
        );
        static List<Character> characters = new List<Character>();

        static List<Event> storyEvents = new List<Event>();

        static int strategicDecisionsMade = 0; // Para influir en el final
        static int braveActionsTaken = 0;     // Para influir en el final

        // --- Funciones del juego ---

        // Helper para el efecto de escritura automática
        public static void TypewriterWrite(string text, int delay = 40, ConsoleColor color = ConsoleColor.White, bool newLine = true)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            if (newLine)
            {
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        static void PlayIntroAnimation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            TypewriterWrite("\nIniciando simulación de combate...", 50);
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                TypewriterWrite("\nCargando Historia.  ");
                Thread.Sleep(300);
                Console.Clear();
                TypewriterWrite("\nCargando Historia.. ");
                Thread.Sleep(300);
                Console.Clear();
                TypewriterWrite("\nCargando Historia...");
                Thread.Sleep(300);
            }
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            TypewriterWrite("\n*** La Guerra de las Trincheras: La Historia Interactiva del General Hanscunt ***\n", 70);
            Console.ResetColor();
            Thread.Sleep(2000);
        }

        static string DisplayMainMenu()
        {
            string[] frames = new string[]
            {
            "  (  )  \n  //\\  ",
            "  ( )   \n  //\\  ",
            "  (  ) \n  //\\  "
            };

            Random rnd = new Random();
            int frameIndex = rnd.Next(0, frames.Length); // Elegir un frame aleatorio para la "animación"

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            TypewriterWrite("==========================================", 10);
            Console.WriteLine(frames[frameIndex]); // Mostrar la figura animada instantáneamente
            TypewriterWrite("        --- MENÚ PRINCIPAL ---        ", 20);
            TypewriterWrite("==========================================", 10);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            TypewriterWrite("1. Iniciar Nueva Campaña", 15);
            TypewriterWrite("2. Ver Perfil de Hanscunt", 15);
            TypewriterWrite("3. Salir", 15);
            TypewriterWrite("------------------------------------------", 10);

            Thread.Sleep(500); // Pausa para que el usuario pueda leer el menú completo

            // Usar TypewriterWrite para el prompt de entrada, sin nueva línea al final
            TypewriterWrite("Introduce tu opción: ", 20, ConsoleColor.Green, false);

            string input = Console.ReadLine() ?? string.Empty; // Leer la entrada del usuario
            Console.ResetColor(); // Asegurar que el color se reinicie después de la entrada
            return input;
        }

        static void InitializeGame()
        {
            // Reiniciar variables para una nueva campaña
            generalHanscunt = new Character("General Hanscunt", "General de División", "Un estratega veterano de la Gran Guerra.", 80);
            strategicDecisionsMade = 0;
            braveActionsTaken = 0;

            characters.Clear();
            characters.Add(generalHanscunt);

            storyEvents.Clear();
            storyEvents.Add(new Event(
                "Ataque a la Trinchera 7",
                "Se informa de un ataque enemigo masivo a la Trinchera 7. Tus tropas necesitan órdenes.",
                new DateTime(1916, 7, 14),
                new List<string> { "General Hanscunt", "Tropas de Infantería" }
            ));

            storyEvents.Add(new Event(
                "Escasez Crítica de Suministros",
                "Una interrupción en las líneas de suministro deja a tus tropas con raciones limitadas. La moral empieza a decaer.",
                new DateTime(1916, 9, 21),
                new List<string> { "General Hanscunt", "Logística del Frente" },
                (charac) => charac.AdjustMorale(-10)
            ));

            storyEvents.Add(new Event(
                "Avistamiento de Artillería Enemiga",
                "Exploradores reportan una nueva batería de artillería enemiga posicionándose para bombardear tu sector.",
                new DateTime(1917, 3, 5),
                new List<string> { "General Hanscunt", "Exploradores" }
            ));

            storyEvents.Add(new Event(
                "Última Ofensiva",
                "El alto mando ordena una ofensiva final para romper el frente. Es una operación de alto riesgo.",
                new DateTime(1918, 10, 20),
                new List<string> { "General Hanscunt", "Alto Mando" }
            ));
        }

        static void StartCampaign()
        {
            InitializeGame();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            TypewriterWrite("\n--- INICIANDO CAMPAÑA ---\n", 40);
            Console.ResetColor();
            generalHanscunt.DisplayInfo();
            Thread.Sleep(2000);

            foreach (Event _event in storyEvents)
            {
                Console.Clear();
                _event.DisplayEvent();
                Thread.Sleep(2000);
                _event.OnExecute?.Invoke(generalHanscunt); // Ejecutar acción del evento si existe
                Thread.Sleep(1000);

                switch (_event.Name)
                {
                    case "Ataque a la Trinchera 7":
                        HandleTrenchAttackDecision();
                        break;
                    case "Escasez Crítica de Suministros":
                        HandleSupplyShortageDecision();
                        break;
                    case "Avistamiento de Artillería Enemiga":
                        HandleArtilleryDecision();
                        break;
                    case "Última Ofensiva":
                        HandleFinalOffensiveDecision();
                        break;
                }
                Thread.Sleep(1500);
            }

            DetermineEnding();
            Console.ForegroundColor = ConsoleColor.Green;
            TypewriterWrite("\nPresiona ENTER para volver al menú principal.", 25);
            Console.ResetColor();
            Console.ReadLine();
        }

        static void HandleTrenchAttackDecision()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            TypewriterWrite("\n¿Cómo respondes al ataque a la Trinchera 7?", 30);
            TypewriterWrite("1. Organizar una contraofensiva inmediata y agresiva. (Alto riesgo, posible gran victoria o desastre)", 20);
            TypewriterWrite("2. Mantener la posición defensiva y solicitar refuerzos. (Menor riesgo, espera)", 20);
            Console.ResetColor();

            string choice = Console.ReadLine() ?? string.Empty;
            if (choice == "1")
            {
                TypewriterWrite("Lideras una contraofensiva audaz. Las bajas son altas, pero la trinchera es recuperada.\n", 30, ConsoleColor.Green);
                generalHanscunt.AdjustMorale(15);
                braveActionsTaken++;
                strategicDecisionsMade++;
            }
            else
            {
                TypewriterWrite("Mantienes la defensa. La trinchera resiste hasta la llegada de los refuerzos, pero pierdes terreno crucial.\n", 30, ConsoleColor.Yellow);
                generalHanscunt.AdjustMorale(-5);
                strategicDecisionsMade--; // Decisión menos estratégica o más pasiva
            }
        }

        static void HandleSupplyShortageDecision()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            TypewriterWrite("\nLa moral está baja debido a la escasez. ¿Cómo actúas?", 30);
            TypewriterWrite("1. Racionar severamente las existencias restantes y exigir disciplina. (Afecta moral, pero conserva)", 20);
            TypewriterWrite("2. Enviar patrullas de riesgo a buscar recursos en territorio disputado. (Arriesgado, pero podría subir moral)", 20);
            Console.ResetColor();

            string choice = Console.ReadLine() ?? string.Empty;
            if (choice == "1")
            {
                TypewriterWrite("Implementas un racionamiento estricto. Las tropas lo resienten, pero los suministros duran más.\n", 30, ConsoleColor.Yellow);
                generalHanscunt.AdjustMorale(-10);
                strategicDecisionsMade++;
            }
            else
            {
                TypewriterWrite("Las patrullas regresan con algunos suministros, elevando la moral temporalmente, pero perdiendo hombres.\n", 30, ConsoleColor.Green);
                generalHanscunt.AdjustMorale(5);
                braveActionsTaken++;
            }
        }

        static void HandleArtilleryDecision()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            TypewriterWrite("\nLa artillería enemiga se está preparando. ¿Cuál es tu plan?", 30);
            TypewriterWrite("1. Ordenar un bombardeo preventivo a la posición enemiga. (Ofensiva)", 20);
            TypewriterWrite("2. Reforzar las defensas de la trinchera y esperar el bombardeo. (Defensiva)", 20);
            Console.ResetColor();

            string choice = Console.ReadLine() ?? string.Empty;
            if (choice == "1")
            {
                TypewriterWrite("Tu bombardeo preventivo causa daños al enemigo, pero revela tu posición en el proceso.\n", 30, ConsoleColor.Green);
                generalHanscunt.AdjustMorale(10);
                strategicDecisionsMade++;
            }
            else
            {
                TypewriterWrite("Las defensas resisten el bombardeo, pero la moral de las tropas se ve afectada por la espera.\n", 30, ConsoleColor.Yellow);
                generalHanscunt.AdjustMorale(-5);
            }
        }

        static void HandleFinalOffensiveDecision()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            TypewriterWrite("\nSe ordena la ofensiva final. ¿Cómo la ejecutas?", 30);
            TypewriterWrite("1. Liderar la carga desde el frente, inspirando a tus hombres. (Extremadamente valiente, pero peligroso)", 20);
            TypewriterWrite("2. Dirigir la ofensiva desde un puesto de mando avanzado. (Más estratégico, menos riesgoso personalmente)", 20);
            Console.ResetColor();

            string choice = Console.ReadLine() ?? string.Empty;
            if (choice == "1")
            {
                TypewriterWrite("Tu valentía en el frente galvaniza a las tropas, pero tu vida está en peligro.\n", 30, ConsoleColor.Green);
                generalHanscunt.AdjustMorale(20);
                braveActionsTaken += 2;
            }
            else
            {
                TypewriterWrite("Desde el puesto de mando, diriges la operación con precisión. La ofensiva avanza lentamente.\n", 30, ConsoleColor.Yellow);
                generalHanscunt.AdjustMorale(5);
                strategicDecisionsMade++;
            }
        }

        static void DetermineEnding()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            TypewriterWrite("\n--- FIN DE LA CAMPAÑA ---", 40);
            Console.ResetColor();
            Thread.Sleep(2000);

            TypewriterWrite($"Resultados Clave:\n Moral Final: {generalHanscunt.Morale}\n Decisiones Estratégicas: {strategicDecisionsMade}\n Acciones Valientes: {braveActionsTaken}\n", 30);
            Thread.Sleep(3000);

            // Lógica para determinar los finales
            if (generalHanscunt.Morale >= 70 && strategicDecisionsMade >= 2 && braveActionsTaken >= 2)
            {
                DisplayEnding("Victoria Heroica", "Has liderado a tus tropas con valentía y sabiduría estratégica, logrando una victoria decisiva con un costo tolerable. Eres aclamado como un héroe y tus decisiones cambian el rumbo de la guerra.\n\n¡Felicitaciones, General Hanscunt!", ConsoleColor.Green);
            }
            else if (generalHanscunt.Morale >= 40 && strategicDecisionsMade >= 0)
            {
                DisplayEnding("Victoria Pírrica / Supervivencia Costosa", "Aunque el frente se mantuvo o se logró un avance, la campaña ha sido brutal. Tus tropas están exhaustas y las pérdidas son significativas. La victoria fue tuya, pero a un precio muy alto.\n\nLa guerra ha dejado cicatrices profundas, General.", ConsoleColor.Yellow);
            }
            else
            {
                DisplayEnding("Derrota Trágica", "Tus decisiones llevaron a una serie de reveses. Las tropas han perdido la moral y la línea del frente se ha derrumbado. La campaña termina en retirada y derrota, con graves consecuencias.\n\nUn final sombrío para el General Hanscunt.", ConsoleColor.Red);
            }
        }

        public static void DisplayEnding(string title, string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            TypewriterWrite($"\n--- {title} ---", 40);
            TypewriterWrite(message, 30);
            Console.ResetColor();
            Thread.Sleep(5000);
        }

        public static void Main(string[] args)
        {
            PlayIntroAnimation();

            string choice;
            do
            {
                choice = DisplayMainMenu();

                switch (choice)
                {
                    case "1":
                        StartCampaign();
                        break;
                    case "2":
                        Console.Clear();
                        generalHanscunt.DisplayInfo();
                        Console.ForegroundColor = ConsoleColor.Green;
                        TypewriterWrite("\nPresiona ENTER para volver al menú.", 25);
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Green;
                        TypewriterWrite("\n¡Gracias por jugar! Adiós.\n", 30);
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        TypewriterWrite("Opción no válida. Por favor, intenta de nuevo.\n", 25);
                        Console.ResetColor();
                        Thread.Sleep(1500);
                        break;
                }
            } while (choice != "3");

            Thread.Sleep(2000);
        }
    }
}