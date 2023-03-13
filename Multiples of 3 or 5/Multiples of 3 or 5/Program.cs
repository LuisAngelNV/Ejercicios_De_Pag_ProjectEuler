using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, suma = 0;
            //Si enumeramos todos los números naturales debajo de 10 que son múltiplos de 3 o 5,
            //obtenemos 3, 5, 6 y 9. La suma de estos múltiplos es 23.
            //Encuentra la suma de todos los múltiplos de 3 o 5 por debajo de 1000.
            Console.WriteLine("Programa Multiples of 3 or 5");

            for (i = 0; suma<1000;i++){
                if (i % 3 == 0 || i % 5 == 0){
                    if (suma < 1000)
                    {
                        suma =suma + i;

                       
                    }
                    Console.WriteLine(suma);
                }
                
            }
                 Console.ReadKey();
        }
    }
}
