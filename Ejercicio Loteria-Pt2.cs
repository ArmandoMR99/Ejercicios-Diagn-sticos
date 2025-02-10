namespace Ejercicio_Loteria
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("  Bienvenido al Sorteo las Pachanga ");
            Console.WriteLine("====================================");
            Console.Write("Ingrese el monto de su apuesta: ");
            int apuesta = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese un número de 4 cifras: ");
            int numeroJugador = int.Parse(Console.ReadLine());
            
            int premio = CalcularPremio(numeroJugador, 4321, apuesta);

            Console.WriteLine("====================================");
            if (premio > 0)
                Console.WriteLine("¡Felicidades! Ha ganado" + premio + "pesos");
            else
                Console.WriteLine("Lo sentimos, vuelva a intentarlo la próxima vez.");
            Console.WriteLine("====================================");
        }

        static int CalcularPremio(int jugador, int ganador, int apuesta)
        {
            string strJugador = jugador.ToString("D4");
            string strGanador = ganador.ToString("D4");

            if (strJugador == strGanador)
            {
                Console.WriteLine("¡Número exacto! Premio mayor.");
                return apuesta * 4500;
            }
            
            if (new string(strJugador.OrderBy(c => c).ToArray()) == new string(strGanador.OrderBy(c => c).ToArray()))
            {
                Console.WriteLine("¡Todas las cifras coinciden en desorden!");
                return apuesta * 200;
            }
            
            if (strJugador.Substring(1) == strGanador.Substring(1))
            {
                Console.WriteLine("¡Últimas 3 cifras acertadas en orden!");
                return apuesta * 400;
            }
            
            if (strJugador.Substring(2) == strGanador.Substring(2))
            {
                Console.WriteLine("¡Últimas 2 cifras acertadas en orden!");
                return apuesta * 50;
            }
            
            if (strJugador.Substring(3) == strGanador.Substring(3))
            {
                Console.WriteLine("¡Última cifra acertada!");
                return apuesta * 5;
            }
            
            Console.WriteLine("No hay coincidencias suficientes.");
            return 0;
        }
    }
}

