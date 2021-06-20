using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DSI.Datos
{
    class ReservaVisita
    {
        private int cantidadAlumnos;
        private int cantidadAlumnosConfirmada;
        private DateTime duracionEstimada;
        private DateTime fechaHoraCreacion;
        private DateTime fechaHoraReserva;
        private DateTime horaFinReal;
        private DateTime horarioReal;
        private int id_empleado;
        private int id_exposicion;
        private int id_reservaVisita;

        public int CantidadAlumnos { get => cantidadAlumnos; set => cantidadAlumnos = value; }
        public int CantidadAlumnosConfirmada { get => cantidadAlumnosConfirmada; set => cantidadAlumnosConfirmada = value; }
        public DateTime DuracionEstimada { get => duracionEstimada; set => duracionEstimada = value; }
        public DateTime FechaHoraCreacion { get => fechaHoraCreacion; set => fechaHoraCreacion = value; }
        public DateTime FechaHoraReserva { get => fechaHoraReserva; set => fechaHoraReserva = value; }
        public DateTime HoraFinReal { get => horaFinReal; set => horaFinReal = value; }
        public DateTime HorarioReal { get => horarioReal; set => horarioReal = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Id_exposicion { get => id_exposicion; set => id_exposicion = value; }
        public int Id_reservaVisita { get => id_reservaVisita; set => id_reservaVisita = value; }



        //METODOS
        //sonParaFechaHoraYSede()
    }
}
