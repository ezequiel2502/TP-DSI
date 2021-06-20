using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DSI.Datos
{
    class Obra
    {
        private float ancho;
        private float alto;
        private string descripcion;
        private string codigoSensor;
        private DateTime duracionExtendida;
        private DateTime duracionResumida;
        private DateTime fechaCreacion;
        private DateTime fechaPrimerIngreso;
        private int id_obra;
        private int id_sesion;
        private string nombreObra;
        private float peso;
        private float valuacion;


        //getters and setters
        public float Ancho { get => ancho; set => ancho = value; }
        public float Alto { get => alto; set => alto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string CodigoSensor { get => codigoSensor; set => codigoSensor = value; }
        public DateTime DuracionExtendida { get => duracionExtendida; set => duracionExtendida = value; }
        public DateTime DuracionResumida { get => duracionResumida; set => duracionResumida = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public DateTime FechaPrimerIngreso { get => fechaPrimerIngreso; set => fechaPrimerIngreso = value; }
        public int Id_obra { get => id_obra; set => id_obra = value; }
        public int Id_sesion { get => id_sesion; set => id_sesion = value; }
        public string NombreObra { get => nombreObra; set => nombreObra = value; }
        public float Peso { get => peso; set => peso = value; }
        public float Valuacion { get => valuacion; set => valuacion = value; }


        //Metodos
        //getDuracionResumida()

    }
}
