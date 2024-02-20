using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перестановка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tea = "кофе";
            string coffee = "чай";
            string emptyCup;
            
            emptyCup = tea;
            tea = coffee;
            coffee = emptyCup;

            Console.WriteLine($"в чашке чай:{tea}, в чашке кофе:{coffee}");
        }
    }
}
