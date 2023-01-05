/*Pida datos a un cliente: Nombre, email, cupón

Determine si un cliente tiene un cupon descuento

Muestre un precio rebajado en función del descuento

Muestre el precio de un producto sin descuento si no hay cupón
*/
namespace ejercicio_1
{
    public class Ejercicio1
    {
        public static void ejercicio1()
        {
            float[] precios = {
            124.5f, 78f, 269.99f, 199.9f};
            string nombre, email, preguntaCupon;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su email: ");
            email = Console.ReadLine();
            Console.Write("Tienes un cupón de descuento? (S/N): ");
            preguntaCupon = Console.ReadLine().ToUpper();

            if(preguntaCupon == "S")
            {
                Console.WriteLine("Precios con un descuento del 20%: ");
                foreach(float i in precios)
                {
                    Console.WriteLine(
                        Math.Round((i - i * 0.2), 1));
                }
            }
            else
            {
                Console.WriteLine("Precios sin descuento: ");
                foreach (float i in precios)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
