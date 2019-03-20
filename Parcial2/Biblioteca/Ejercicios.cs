using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ejercicios
    {
        //Metodo Ejercicio 01
        public void ejercicio01()
        {
            int num1, num2, resultado;
            Console.WriteLine("\nIngrese el primer numero");
            num1 = int.Parse(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
            }
            else
            {
                Console.WriteLine("Ingrese el segundo numero");
                num2 = int.Parse(Console.ReadLine());

                resultado = num1 * num2;
                Console.WriteLine("Resultado: " + resultado);
            }

        }

        //Metodo Ejercicio 02
        public void ejercicio02() 
        {
            int num1, num2, resultado;
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            if (num2 == 0) 
            {
                Console.WriteLine("Error: no se puede dividir entre cero");
            }
            else 
            {
                resultado = num1 / num2;
                Console.WriteLine("Resultado: " + resultado);
            }
        }

        //Metodo Ejercicio 03
        public void ejercicio03() 
        {
            string[] nombres = new string[5];

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("\nIngrese el nombre para el alumno " + (i+1));
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine("");
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("El nombre " + (i+1) + "=" + nombres[i]);
            }
        }

        public void ejercicio04()
        {
            int var=1, edad;
            do
            {
                Console.WriteLine("\nIngrese la edad del estudiante " + var);
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("\n**************************************");
                Console.WriteLine("La edad del alumno " + var + " es: " + edad);
                Console.WriteLine("**************************************");

                var++;
            }while(var <= 5);
        }
    }

}
