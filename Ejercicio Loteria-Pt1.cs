namespace Ejercicio_Loteria
{
    internal class Program
    {
        static void Main()
        {
            int numeroJugador;
            int numeroGanador = 4321; 
           

            Console.WriteLine("Bienvenido al Sorteo las Pachangas");
            Console.WriteLine();
            Console.WriteLine("Su Apuesta es de 1000$, Buena Suerte");
            Console.Write("Ingrese 4 Numeros: ");

            numeroJugador = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (numeroGanador == numeroJugador) 
            {
                Console.WriteLine("Felicidades ha Ganado el Sorte de las Pachangas");
            }
            else
            {
                Console.WriteLine("Lo Sentimos Vuelva a Intentarlo la Proxima");
            }
        }
    }

}

