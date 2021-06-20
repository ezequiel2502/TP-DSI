using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DSI.Datos
{
    class Sede
    {
        private int cantMaximaVisitantes;
        private int cantMaxPorGuia;
        private int id_empleado;
        private int id_sede;
        private int id_tarifa;
        private string nombre;

        public int CantMaximaVisitantes { get => cantMaximaVisitantes; set => cantMaximaVisitantes = value; }
        public int CantMaxPorGuia { get => cantMaxPorGuia; set => cantMaxPorGuia = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Id_sede { get => id_sede; set => id_sede = value; }
        public int Id_tarifa { get => id_tarifa; set => id_tarifa = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        //METODOS
        //calcularDuracionAExposicionesVigentes()
        //mostrarCantidadMaximaVisitantes()
        //obtenerTarifasVigentes()
    }
}
