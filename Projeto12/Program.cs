using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
