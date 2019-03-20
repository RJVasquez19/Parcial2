using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\nIngrese una opcion");
                Console.WriteLine("1. MULTIPLICACION");
                Console.WriteLine("2. DIVISION");
                Console.WriteLine("3. CAPTURAR 5 NOMBRES");
                Console.WriteLine("4. CAPTURAR 5 EDAD");
                Console.WriteLine("5. SALIR");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Ejercicios obj = new Ejercicios();
                        obj.ejercicio01();
                        break;
                    case 2:
                        Ejercicios obj1 = new Ejercicios();
                        obj1.ejercicio02();
                        break;
                    case 3:
                        Ejercicios obj2 = new Ejercicios();
                        obj2.ejercicio03();
                        break;
                    case 4:
                        Ejercicios obj3 = new Ejercicios();
                        obj3.ejercicio04();
                        break;
                }


            }while(opcion != 5);
        }
    }
}
