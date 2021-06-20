using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DSI.Datos
{
    class DetalleExposicion
    {
        private int id_detalleExpo;
        private int id_obra;
        private string lugarAsignado;

        public int Id_detalleExpo { get => id_detalleExpo; set => id_detalleExpo = value; }
        public int Id_obra { get => id_obra; set => id_obra = value; }
        public string LugarAsignado { get => lugarAsignado; set => lugarAsignado = value; }


        //METODOS
        //buscarDuracionObras()
    }
}
