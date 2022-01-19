using System;
using System.Collections.Generic;
using System.Linq;

namespace EjerciciosLambda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };

            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla los nombres de los estudiantes
            IEnumerable<string> listanombre =
                details.Select(lista => lista.Nombre);
            Console.WriteLine("Lista de estudiante: ");
            foreach (var Nombre in listanombre)
            {
                Console.WriteLine("Estudiante: " + Nombre);
            }
            Console.ReadLine();

            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            Console.WriteLine("Los estudiantes ordenados por promedios de mayor a menor son: ");
            var estudiante = details.OrderByDescending(a => a.Promedio);
            foreach (var es in estudiante)
            {
                Console.WriteLine(es.Id + "-" + "Promedio: " + es.Promedio + ": " + es.Nombre + " " + es.Apellido);
            }
            Console.ReadLine();

            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            var apellido = details.OrderBy(a => a.Apellido);
            Console.WriteLine("Los estudiantes ordenados por apellidos de forma ascententes son: ");
            foreach (var ap in apellido)
            {
                Console.WriteLine(ap.Apellido);
            }
            Console.ReadLine();

            //4. Muestre por pantalla los datos del estudiante mas joven
            IEnumerable<Estudiante> joven = from estudiant in details
                                            where estudiant.Edad <= 18
                                            orderby estudiant.Id
                                            select estudiant;
            Console.WriteLine("El estudiante mas joven es: ");
            Console.WriteLine(details.OrderBy(s => s.Edad).FirstOrDefault().Nombre);
            foreach (var estudiant in joven)
            {
                Console.WriteLine(estudiant.Id + "-" + " Estudiante: " + estudiant.Nombre + " "
                    + estudiant.Apellido + " con edad de: " + estudiant.Edad + " y Promedio de: " + estudiant.Promedio);
            }
            Console.ReadLine();

            Console.WriteLine("SEGUNDA LISTA");
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };

            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla el cuadrado de los números
            var cuadrado = list.Select(x => x * x);
            Console.WriteLine($"El cuadrado de los numeros son: {string.Join(", ", cuadrado)}");
            Console.ReadLine();

            //2. Muestre por pantalla los números pares
            var numPares = list.Where(n => n % 2 == 0).ToList();
            int pares = list.Count(n => n % 2 == 0);
            Console.WriteLine($"Hay {pares} Numeros pares y son: {string.Join(", ", numPares)}");
            Console.ReadLine();

            //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            var numImpares = list.Where(n => n % 2 != 0).ToList();
            Console.WriteLine($"Los numeros impares son: {string.Join(" ", numImpares)}");
            Console.WriteLine("Multiplicdo por 5 es igual: ");
            foreach (var impar in numImpares)
            {
                Console.WriteLine(impar*5);
            }
            Console.ReadLine();
        }
    }
}
