namespace FibonacciPrimos
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Números Primos en Fibonacci ===");
            Console.Write("Ingrese cuántos términos desea ver: ");
            int n = int.Parse(Console.ReadLine());

            MostrarPrimosFibonacci(n);
        }

        static void MostrarPrimosFibonacci(int n)
        {
            int a = 0, b = 1, temp;

            for (int i = 0; i < n; i++)
            {
                if (EsPrimo(a)) Console.WriteLine(a);

                temp = a + b;
                a = b;
                b = temp;
            }
        }

        static bool EsPrimo(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
                if (num % i == 0) return false;
            return true;
        }
    }
}
