using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {//4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            int a, b, c, d, menor;
            Console.WriteLine("Escriba un número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro:");
            d = int.Parse(Console.ReadLine());

            if(a < b)
                menor = a;
            else
                menor = b;           
            if(c < menor)
                menor = c;
            if(d < menor)
                menor = d;
            Console.WriteLine("El menor de los números es:" + menor);


        }   

    }
}
