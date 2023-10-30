using System;

namespace TABLA_DE_MULTIPLICAR_CON_RECURSION
{
    class Program
    {
        static void ImprimirTabla(int numero, int multiplicador)
        {
            if (multiplicador <= 12)
            {
                int resultado = numero * multiplicador;
                Console.WriteLine($"{numero} * {multiplicador} = {resultado}");
                ImprimirTabla(numero, multiplicador + 1);
            }
        }

        static void Main(string[] args)
        {
            int NUM;
            string linea;
            Console.Write("DIGITE NÚMERO: ");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);

            ImprimirTabla(NUM, 1);

            Console.Write("Pulse una tecla: ");
            Console.ReadLine();
        }
    }
}
