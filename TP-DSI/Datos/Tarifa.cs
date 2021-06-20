using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DSI.Datos
{
    class Tarifa
    {
        private DateTime fechaFinVigencia;
        private DateTime fechaInicioVigencia;
        private int id_tarifa;
        private int id_tipoEntrada;
        private int id_tipoVisita;
        private float monto;
        private float montoTipoEntrada;

        public DateTime FechaFinVigencia { get => fechaFinVigencia; set => fechaFinVigencia = value; }
        public DateTime FechaInicioVigencia { get => fechaInicioVigencia; set => fechaInicioVigencia = value; }
        public int Id_tarifa { get => id_tarifa; set => id_tarifa = value; }
        public int Id_tipoEntrada { get => id_tipoEntrada; set => id_tipoEntrada = value; }
        public int Id_tipoVisita { get => id_tipoVisita; set => id_tipoVisita = value; }
        public float Monto { get => monto; set => monto = value; }
        public float MontoTipoEntrada { get => montoTipoEntrada; set => montoTipoEntrada = value; }

        //METODOS
        //mostrarMontosVigentes()
    }
}
