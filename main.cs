using ejercicio_1;
using ejercicio_2;

namespace main
{
    internal class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Que ejercicio desea ver?");
            Console.Write(
                "1. Ejercicio 1\n" +
                "2. Ejercicio 2\n");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Ejercicio1.ejercicio1();
                    break;
                case 2:
                    Ejercicio2.ejercicio2();
                    break;
                default:
                    Console.WriteLine("Opción invalida");
                    break;
            }

        }
    }
}
