using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicaprincipal
{
    internal class Paquetes
    {
        public int id { get; set; }
        public int dimension { get; set; }
        public int idcamion { get; set; }

        public Paquetes(int Id, int Dimension, int Idcamion)
        {
            Id = id;
            Dimension = dimension;
            Idcamion = idcamion;
        }
    }
}
