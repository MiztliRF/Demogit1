using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demogit1
{
    class Program
    {
        public string Saludo { get; set; }
        public Program()
        {
            Saludo = "Hola Uadeo";
        }

        static void Main(string[] args)
        {
            var saludo = new Program();
            Console.WriteLine(saludo.Saludo);
            Console.Read();
        }
    }
}
