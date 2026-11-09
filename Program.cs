using System;

namespace Ejercicios_Secuenciales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio9();

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

        // Ejercicio 6: suma y promedio de cuatro valores
        static void Ejercicio6()
        {
            double v1 = LeerDecimal("Introduce el primer valor: ");
            double v2 = LeerDecimal("Introduce el segundo valor: ");
            double v3 = LeerDecimal("Introduce el tercer valor: ");
            double v4 = LeerDecimal("Introduce el cuarto valor: ");

            double suma = v1 + v2 + v3 + v4;
            double promedio = suma / 4;

            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"El promedio es: {promedio}");
        }

        // Ejercicio 7: coste total de una compra
        static void Ejercicio7()
        {
            double precio = LeerDecimal("Precio del artículo: ");
            int cantidad = LeerEntero("Cantidad que lleva el cliente: ");

            double total = precio * cantidad;
            Console.WriteLine($"El coste total es: {total:F2}€");
        }

        // Ejercicio 8: nota final del módulo
        static void Ejercicio8()
        {
            double parcial1 = LeerDecimal("Nota del primer parcial: ");
            double parcial2 = LeerDecimal("Nota del segundo parcial: ");
            double examen = LeerDecimal("Nota del examen: ");
            double trabajo = LeerDecimal("Nota del trabajo final: ");

            // 50% promedio de parciales, 30% examen, 20% trabajo
            double promedioParciales = (parcial1 + parcial2) / 2;
            double notaFinal = promedioParciales * 0.5 + examen * 0.3 + trabajo * 0.2;

            Console.WriteLine($"Tu nota final en Desarrollo de Interfaces es: {notaFinal:F2}");
        }

        // Ejercicio 9: porcentaje de participación de tres socios
        static void Ejercicio9()
        {
            double aporte1 = LeerDecimal("Aportación del socio 1: ");
            double aporte2 = LeerDecimal("Aportación del socio 2: ");
            double aporte3 = LeerDecimal("Aportación del socio 3: ");

            double total = aporte1 + aporte2 + aporte3;

            // Si no hay aportaciones, no se puede calcular el porcentaje
            if (total == 0)
            {
                Console.WriteLine("El total aportado es 0, no se pueden calcular porcentajes.");
                return;
            }

            double porcentaje1 = aporte1 / total * 100;
            double porcentaje2 = aporte2 / total * 100;
            double porcentaje3 = aporte3 / total * 100;

            Console.WriteLine("El porcentaje del socio 1 es {0:F2}%, del socio 2 es {1:F2}% y del socio 3 es {2:F2}%",
                porcentaje1, porcentaje2, porcentaje3);
        }
    }
}