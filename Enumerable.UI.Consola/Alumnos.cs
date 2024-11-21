using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable.UI.Consola
{
    internal class Alumnos
    {
        public int Matricula { get; set; }
        public string ?Nombre { get; set; }
        public int Edad { get; set; }

        public override string ToString()
        {
            return $"{Matricula}\t{Nombre}\t{Edad}";
        }
    }
}
