using System;

namespace Lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex6.Ex6
            Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
            descrescatoare.
            • Exemplu: citim 3,9,0 Afisam : 9 3 0*/

            Console.WriteLine("Introduceti x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti z: ");
            int z = int.Parse(Console.ReadLine());

            int max = Math.Max(x, Math.Max(y, z));
            int min = Math.Min(x, Math.Min(y, z));
            int middle = x + y + z - max - min;

            Console.WriteLine("Cele trei numere în ordine descrescătoare sunt:");
            Console.WriteLine(max + " " + middle + " " + min);
        }
    }
}