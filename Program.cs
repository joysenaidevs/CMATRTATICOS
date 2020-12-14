using System;
using CMATRTATICOS.classe;

namespace CMATRTATICOS
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamamos a classe estatica sem precisar instanciar

            Console.WriteLine( Conversor.DolarParaReal(4f) );
            Console.WriteLine( Conversor.RealParaDolar(50f));

            Console.WriteLine( Conversor.EuroParaReal(9f));
            Console.WriteLine( Conversor.RealParaEuro(10f));

            //classe math

            Console.WriteLine(Math.Pow(2,4));
        }
    }
}
