using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opciones;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Programa que muestre los numeros de n al 1 de manera descendente");
                Console.WriteLine("2. Programa que muestre de 1 a 5 con while");
                Console.WriteLine("3. Programa que muestre el numero minimo de una lista");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opcion (1-4)");

                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {
                        case 1:

                            numerosDescendentes();

                            break;

                        case 2:

                            numerosWhile();

                            break;

                        case 3:

                            minimoLista();

                            break;

                        case 4:
                            Console.WriteLine("Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

            } while (opciones != 4);
        }

        static void numerosDescendentes()
        {
            Console.WriteLine("Ingrese un numero (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 1)
            {
                for (int i = n; i >= 1; i--)
                {
                    Console.Write($"numero > {i}\n");
                }
                
            }   
            else{
                Console.WriteLine("El número ingresado debe ser mayor o igual a 1.");
                }
            }// Fin de numerosDescendentes

        static void numerosWhile()
        {
            int contador = 1;
            while (contador <= 5)
            {
                Console.Write($"Numero >>{contador} \n ");
                contador++;
            }
        } //Fin de numerosWhile

        static void minimoLista()
        {
            List <int> numeros = new List<int> {24,15,45,35,14,10};

            int minimo = numeros[0]; //Inicializar con valor del indice 0

            foreach (int numero1 in numeros)
            
                if(numero1 < minimo)
            
            {
                if(numero1 < minimo)
                {
                    minimo = numero1; //Actualizar el valor minimo
                }

            }

        Console.WriteLine ("El numero mas pequeño de la lista es > " + minimo);
        }//Fin de minimoLista
    }
}

//AUTOEVALUCION 10 U20230466