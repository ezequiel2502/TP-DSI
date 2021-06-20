using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DSI.Datos
{
    class Exposicion
    {
        private DateTime fechaFin;
        private DateTime fechaFinReplanificada;
        private DateTime fechaInicio;
        private DateTime fechaInicioReplanificada;
        private DateTime horaApertura;
        private DateTime horaCierre;
        private int id_detalleExpo;
        private int id_exposicion;
        private int id_sesion;
        private string nombre;

        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaFinReplanificada { get => fechaFinReplanificada; set => fechaFinReplanificada = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaInicioReplanificada { get => fechaInicioReplanificada; set => fechaInicioReplanificada = value; }
        public DateTime HoraApertura { get => horaApertura; set => horaApertura = value; }
        public DateTime HoraCierre { get => horaCierre; set => horaCierre = value; }
        public int Id_detalleExpo { get => id_detalleExpo; set => id_detalleExpo = value; }
        public int Id_exposicion { get => id_exposicion; set => id_exposicion = value; }
        public int Id_sesion { get => id_sesion; set => id_sesion = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //METODOS
        //calcularDuracionObrasExpuestas()
        //esVigente()
    }
}
