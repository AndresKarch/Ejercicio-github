using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace Logicaprincipal
{
    public class Logica
    {
        List<Camiones> listacamiones = new List<Camiones>();
        List<Paquetes> listapaqutes = new List<Paquetes>();
        
        public void CargaCamiones(int id, string marca, string modelo, int volumen)
        {
            Camiones Camion = new Camiones(id, marca, modelo, volumen);
            listacamiones.Add(Camion);
            
        }
        public void CargaPaquetes(int id, int altura, int largo, int ancho)
        {
            int idcamion = 0;
            int dimension = altura*largo*ancho;
            foreach (Camiones camion in listacamiones)
            {
                if (camion.volumen > dimension)
                {
                    camion.volumen = camion.volumen - dimension;
                    idcamion = camion.id;
                    break;
                }
            }
            Paquetes paquete = new Paquetes(id, dimension, idcamion);
        }
    }
}
