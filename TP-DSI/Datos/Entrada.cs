using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DSI.Datos
{
    class Entrada
    {
        private DateTime fechaVenta;
        private DateTime horaVenta;
        private int id_sede;
        private int id_tarifa;
        private float monto;
        private int numero;

        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public DateTime HoraVenta { get => horaVenta; set => horaVenta = value; }
        public int Id_sede { get => id_sede; set => id_sede = value; }
        public int Id_tarifa { get => id_tarifa; set => id_tarifa = value; }
        public float Monto { get => monto; set => monto = value; }
        public int Numero { get => numero; set => numero = value; }


        //METODOS
        //getNro()
        //new()
        //sonDeFechaHoraYSede()
    }
}
