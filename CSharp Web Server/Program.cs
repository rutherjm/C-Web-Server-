using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Web_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectInterface si = new SelectInterface();
            si.ShowDialog();
            Console.ReadLine();
        }
    }
}
