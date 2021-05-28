using System;
using System.Collections.Generic;
using DatasLeonardo;
using Cell_Leonardo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Leonardo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular aux = new Celular("aeiou");
            Console.WriteLine(aux.Traducao);
        }

    }
}
