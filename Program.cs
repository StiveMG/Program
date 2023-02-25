Console.WriteLine("Ingrese el Número de se opción: " +
                  "\n Opcion 1 = Calcular Renta " + 
                  "\n Opcion 2 = Sala de Juegos " + 
                  "\n Opcion 3 = Pizzas el Fercho" +
                  "\n Opcion 4 = Rendimiento" +
                  "\n Opcion 0 = Salir");
                  
int opcion = Int32.Parse(Console.ReadLine());

if (opcion > 0 && opcion < 5)
{
    while (opcion != 0)
    {
        if (opcion == 1)
        {
            Console.WriteLine("Ingrese su Renta trimestral: ");
            int renta = Int32.Parse(Console.ReadLine());
            int valorAnual = renta * 4;
                    
            if (valorAnual < 10000)
            {
                double impuesto = (double)(valorAnual * 0.05);
                double totalPagar = valorAnual + impuesto;
                Console.WriteLine("Su renta Anual es de: $" + valorAnual +
                "\nSu % de impuesto es: $" + impuesto +
                "\nValor Total a Pagar es : $" + totalPagar);
            }else if (valorAnual == 10000 && valorAnual < 20000)
            {
                double impuesto = (double)(valorAnual * 0.10);
                double totalPagar = valorAnual + impuesto;
                Console.WriteLine("Su renta Anual es de: $" + valorAnual +
                "\n Su % de impuesto es: $" + impuesto +
                "\n Valor Total a Pagar es : $" + totalPagar);
            }else if (valorAnual == 20000 && valorAnual < 35000)
            {
                double impuesto = (double)(valorAnual * 0.15);
                double totalPagar = valorAnual + impuesto;
                Console.WriteLine("Su renta Anual es de: $" + valorAnual +
                "\n Su % de impuesto es: $" + impuesto +
                "\n Valor Total a Pagar es : $" + totalPagar);
            }else if (valorAnual == 35000 && valorAnual < 45000)
            {
                double impuesto = (double)(valorAnual * 0.20);
                double totalPagar = valorAnual + impuesto;
                Console.WriteLine("Su renta Anual es de: $" + valorAnual +
                "\n Su % de impuesto es: $" + impuesto +
                "\n Valor Total a Pagar es : $" + totalPagar);
            }else if (valorAnual >= 45000)
            {
                double impuesto = (double)(valorAnual * 0.30);
                double totalPagar = valorAnual + impuesto;
                Console.WriteLine("Su renta Anual es de: $" + valorAnual +
                "\n Su % de impuesto es: $" + impuesto +
                "\n Valor Total a Pagar es : $" + totalPagar);
            }else
            {
                Console.WriteLine("Ocurrio un ERROR al ingresar su Renta");
            }
        }

        if (opcion == 2)
        {
            int valorEntrada = 15000;
            Console.WriteLine("Ingrese su Nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad en números: ");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 4)
            {
                Console.WriteLine(nombre + ", su entrada es Gratis!!");
            }else if (edad == 4 || edad < 18)
            {
                double descuento = valorEntrada * 0.05;
                double totalEntrada = valorEntrada - descuento;
                Console.WriteLine(nombre + ", su entrada cuesta: " + totalEntrada + " Con un descuento de " + descuento);
            }else if (edad >= 18)
            {
                double descuento = valorEntrada * 0.03;
                double totalEntrada = valorEntrada - descuento;
                Console.WriteLine(nombre + ", su entrada cuesta: " + totalEntrada + " Con un descuento de " + descuento);
            }
        }

        if (opcion == 3)
        {
            Console.WriteLine("-- Bienvenido a Pizzas el Fercho --" +
            "\n MENU: " +
            "\n Precione 1 para elegir una Pizza Vegetariana" +
            "\n Precione 2 para elegir una Pizza No Vegetariana");
            int elegirPizza = Int32.Parse(Console.ReadLine());

            if (elegirPizza == 1)
            {
                Console.WriteLine("-Elija el ingrediente de su Pizza Vegetariana" +
                "\n Precione '1' para una Pizza Vegetariana con Pimiento, Mozzarella y Tomate" +
                "\n Precione '2' para una Pizza Vegetariana con Champiñones, Mozzarella y Tomate" + 
                "\n Precione '0' para Terminar con el Pedido");
                int ingrediente = Int32.Parse(Console.ReadLine());

                while (ingrediente > 0 && ingrediente <= 2)
                {
                    if (ingrediente == 1)
                 {
                    Console.WriteLine("-Su Pizza es Vegetariana, con los siguientes ingredientes: " +
                    "\n*Pimiento." +
                    "\n*Mozzarella." +
                    "\n*Tomate.");
                 }else if (ingrediente == 2)
                 {
                    Console.WriteLine("-Su Pizza es Vegetariana, con los siguientes ingredientes: " +
                    "\n*Champiñones." +
                    "\n*Mozzarella." +
                    "\n*Tomate.");
                 }else if (ingrediente >= 3)
                 {
                    Console.WriteLine("Ingreso un número incorrecto");
                 }

                 Console.WriteLine("!Vuelve a Elegir¡");
                 ingrediente = Int32.Parse(Console.ReadLine());
                }
            }else if (elegirPizza == 2)
            {
                Console.WriteLine("-Elija el ingrediente de su Pizza No Vegetariana" +
                "\n Precione '1' para una Pizza con Pepperoni, Mozzarella y Tomate" +
                "\n Precione '2' para una Pizza con Salami, Mozzarella y Tomate" +
                "\n Precione '3' para una Pizza con Pollo, Mozzarella y Tomate" + 
                "\n Precione '0' para Terminar con el Pedido");
                int ingrediente = Int32.Parse(Console.ReadLine());

                while (ingrediente > 0 && ingrediente <= 3)
                {
                    if (ingrediente == 1)
                 {
                    Console.WriteLine("-Su Pizza No es Vegetariana, con los siguientes ingredientes: " +
                    "\n*Pepperoni." +
                    "\n*Mozzarella." +
                    "\n*Tomate.");
                 }else if (ingrediente == 2)
                 {
                    Console.WriteLine("-Su Pizza No es Vegetariana, con los siguientes ingredientes: " +
                    "\n*Salami." +
                    "\n*Mozzarella." +
                    "\n*Tomate.");
                 }else if (ingrediente == 3)
                 {
                    Console.WriteLine("-Su Pizza No es Vegetariana, con los siguientes ingredientes: " +
                    "\n*Pollo." +
                    "\n*Mozzarella." +
                    "\n*Tomate.");
                 }else if (ingrediente >= 4)
                 {
                    Console.WriteLine("Ingreso un número incorrecto");
                 }
                 Console.WriteLine("!Vuelve a Elegir¡");
                 ingrediente = Int32.Parse(Console.ReadLine());
                }
            }
        }

        if (opcion == 4)
        {
            Console.WriteLine("¿Cual Fue Su Puntuación?" +
            "\n Precione 1: Puntuación de 0.0" +
            "\n Precione 2: Puntuación de 0.4" +
            "\n Precione 3: Puntuación de 0.6");
            int puntuacion = int.Parse(Console.ReadLine()); 

            if (puntuacion == 1)
            {
                Console.WriteLine("Su rendimiento es !INACEPTABLE¡, por lo tanto no tiene Bonificación");
            }else if (puntuacion == 2)
            {
                double bonificacion = (double)(50000 * 0.4);
                Console.WriteLine("Su rendimiento es !ACEPTABLE¡ por lo tanto su bonificación es de: $" + bonificacion);
            }else if (puntuacion == 3)
            {
                double bonificacion = (double)(50000 * 0.6);
                Console.WriteLine("Su rendimiento es !MERITORIO¡ por lo tanto su bonificación es de: $" + bonificacion);
            }else if (puntuacion <= 0 || puntuacion >= 4)
            {
                Console.WriteLine("Opción Incorrecta");
            }
        }

        if (opcion == 0)
        {
            Console.WriteLine("Muchas gracias Fercho");
        }

        if (opcion >= 5)
        {
            Console.WriteLine("Opción Incorrecta");
        }

     Console.WriteLine("\nIngrese una nueva opcion: ");
     opcion = Int32.Parse(Console.ReadLine());
    }

}else if (opcion == 0)
{
    Console.WriteLine("Muchas gracias Fercho");
}else
{
    Console.WriteLine("Opción No Valida");
}