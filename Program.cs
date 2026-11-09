using System;

namespace Ejercicios_Secuenciales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();

            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadKey();
        }

        // Pide un entero y repite hasta que sea válido
        static int LeerEntero(string mensaje)
        {
            int numero;
            bool esValido;
            do
            {
                Console.Write(mensaje);
                esValido = int.TryParse(Console.ReadLine(), out numero);
                if (!esValido)
                {
                    Console.WriteLine("Entrada no válida. Introduce un número entero.");
                }
            } while (!esValido);
            return numero;
        }

        // Ejercicio 1: operaciones con dos números
        static void Ejercicio1()
        {
            int numero1 = LeerEntero("Introduce el primer número: ");
            int numero2 = LeerEntero("Introduce el segundo número: ");

            Console.WriteLine($"La suma es {numero1 + numero2}");
            Console.WriteLine($"La resta es: {numero1} - {numero2} = {numero1 - numero2}");
            Console.WriteLine($"La multiplicación es: {numero1 * numero2}");

            // Evitamos dividir entre cero
            if (numero2 != 0)
            {
                Console.WriteLine($"La división es: {numero1 / numero2}");
                Console.WriteLine($"El módulo es: {numero1 % numero2}");
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
        }
    }
}