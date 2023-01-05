/*Haz una lista de lenguajes de programación, por ejemplo:
C#, Java, C++. Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. 
Presenta el resultado en consola.*/

namespace ejercicio_2
{
    public class Ejercicio2
    {
        public static void ejercicio2()
        {
            Console.WriteLine("Seleccione una opción numerica: ");
            Console.Write(
                "1 - Java\n" +
                "2 - C++\n" +
                "3 - C#\n" +
                "4 - Python\n");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Ha seleccionado Java");
                    break;
                case 2:
                    Console.WriteLine("Ha seleccionado C++");
                    break;
                case 3:
                    Console.WriteLine("Ha seleccionado C#");
                    break;
                case 4:
                    Console.WriteLine("Ha seleccionado Python");
                    break;
                default:
                    Console.WriteLine("No selccionó ninguna opción valida");
                    break;
            }
       
        }
    }
}