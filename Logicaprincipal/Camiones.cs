using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicaprincipal
{
    internal class Camiones
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int volumen { get; set; }

        public Camiones(int Id, string Marca, string Modelo, int Volumen)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Volumen = volumen;
        }
    }
}
