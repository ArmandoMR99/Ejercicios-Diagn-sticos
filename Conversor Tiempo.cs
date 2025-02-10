namespace ConversorTiempo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Conversor de Segundos a HH:MM:SS ===");
            Console.Write("Ingrese la cantidad de segundos: ");
            int segundos = int.Parse(Console.ReadLine());

            string formatoTiempo = ConvertirSegundos(segundos);
            Console.WriteLine("Tiempo en formato HH:MM:SS -> "+ formatoTiempo);
        }

        static string ConvertirSegundos(int segundos)
        {
            int horas = segundos / 3600;
            int minutos = (segundos % 3600) / 60;
            int segRestantes = segundos % 60;

            return $"{horas:D2}:{minutos:D2}:{segRestantes:D2}";
        }
    }
}
