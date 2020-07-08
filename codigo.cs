using System;

namespace Pactica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precio del producto:");
            int precio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Desea pagar con efectivo = 1 o tarjeta = 2?");
            int metodoPago = Int32.Parse(Console.ReadLine());
            switch (metodoPago)
            {
                case 1:
                    Console.WriteLine("Efectivo.\n");
                    Console.WriteLine("Pago realizado, gracias por su compra.\n");
                    break;
                case 2:
                    Console.WriteLine("Targeta.");
                    Console.WriteLine("Digite su numero de tarjeta: ");
                    int intentos = 1;
                    while (intentos >= 3)
                    {
                        String numeroTarjeta = Console.ReadLine();
                        if (numeroTarjeta.Length == 16)
                        {
                            Console.WriteLine("Tarjeta aceptada!\n");                  
                            Console.WriteLine("Pago realizado, gracias por su compra.\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Targeta rechazada\n");
                            Console.WriteLine("Vuelva a intentarlo.");
                        }
                        intentos++;
                    }
                    break;
            }
            Console.WriteLine("Pase un buen dia!");
        }
    }
}
