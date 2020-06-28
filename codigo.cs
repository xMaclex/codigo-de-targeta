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
                String numeroTarjeta  = Console.ReadLine();

            if (numeroTarjeta.Length == 16)
            {
                    Console.WriteLine("Tarjeta aceptada!\n");                  
                    Console.WriteLine("Pago realizado, gracias por su compra.\n");
            }
            else
            {
                    Console.WriteLine("Targeta rechazada\n");
                    Console.WriteLine("Vuelva a intentarlo.\n");
                    Console.WriteLine("Digite su numero de tarjeta:");
                    numeroTarjeta = Console.ReadLine();
            
            if (numeroTarjeta.Length == 16)
            {
                    Console.WriteLine("Tarjeta aceptada!\n");                  
                    Console.WriteLine("Pago realizado, gracias por su compra.\n");
            }
            else
            {
                    Console.WriteLine("Tarjeta rechazada\n");
                    Console.WriteLine("vuelva a intentarlo mas tarde o llame a su aseguradora de tarjeta\n");
            }
            }
            break;
            }
            Console.WriteLine("Pase un buen dia!");
        }
    }
}
