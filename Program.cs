using System;

namespace Ejercicios_Secuenciales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio5();

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

        // Pide un número con decimales y repite hasta que sea válido
        static double LeerDecimal(string mensaje)
        {
            double numero;
            bool esValido;
            do
            {
                Console.Write(mensaje);
                esValido = double.TryParse(Console.ReadLine(), out numero);
                if (!esValido)
                {
                    Console.WriteLine("Entrada no válida. Introduce un número.");
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

        // Ejercicio 2: cuenta del bar
        static void Ejercicio2()
        {
            // Precios fijos del bar
            const double PRECIO_HAMBURGUESA = 5.00;
            const double PRECIO_PAPAS = 1.75;
            const double PRECIO_BEBIDA = 1.10;

            int hamburguesas = LeerEntero("Cantidad de hamburguesas: ");
            int papas = LeerEntero("Cantidad de papas: ");
            int bebidas = LeerEntero("Cantidad de bebidas: ");

            double total = hamburguesas * PRECIO_HAMBURGUESA
                         + papas * PRECIO_PAPAS
                         + bebidas * PRECIO_BEBIDA;

            // F2 muestra siempre dos decimales
            Console.WriteLine($"Cantidad a pagar: {total:F2}€");
        }

        // Ejercicio 3: funciones de la clase Math
        static void Ejercicio3()
        {
            double numero = LeerDecimal("Introduce un número: ");

            // Para Max y Min necesitamos un segundo número, lo fijamos aquí
            double otroNumero = 10;

            Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
            Console.WriteLine($"Potencia al cubo: {Math.Pow(numero, 3)}");

            // La raíz de un negativo no existe, así que lo comprobamos
            if (numero >= 0)
            {
                Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");
            }
            else
            {
                Console.WriteLine("No existe la raíz cuadrada de un número negativo.");
            }

            // Seno y coseno trabajan con radianes
            Console.WriteLine($"Seno: {Math.Sin(numero)}");
            Console.WriteLine($"Coseno: {Math.Cos(numero)}");
            Console.WriteLine($"Máximo entre {numero} y {otroNumero}: {Math.Max(numero, otroNumero)}");
            Console.WriteLine($"Mínimo entre {numero} y {otroNumero}: {Math.Min(numero, otroNumero)}");
        }

        // Ejercicio 4: perímetro de un cuadrado
        static void Ejercicio4()
        {
            double lado = LeerDecimal("Introduce el valor de un lado: ");
            double perimetro = lado * 4;
            Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
        }

        // Ejercicio 5: suma de los dos primeros y producto de los dos últimos
        static void Ejercicio5()
        {
            double n1 = LeerDecimal("Introduce el primer número: ");
            double n2 = LeerDecimal("Introduce el segundo número: ");
            double n3 = LeerDecimal("Introduce el tercer número: ");
            double n4 = LeerDecimal("Introduce el cuarto número: ");

            Console.WriteLine($"La suma de los dos primeros es: {n1 + n2}");
            Console.WriteLine($"El producto del tercero y el cuarto es: {n3 * n4}");
        }
    }
}