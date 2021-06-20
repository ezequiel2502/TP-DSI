﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DSI.Datos
{
    class Empleado
    {
        private int id_empleado;
        private string nombre;
        private string apellido;
        private int dni;
        private string cuit;
        private string domicilio;
        private string codigoValidacion;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private string mail;
        private string sexo;
        private string telefono;

        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Cuit { get => cuit; set => cuit = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string CodigoValidacion { get => codigoValidacion; set => codigoValidacion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefono { get => telefono; set => telefono = value; }


        //Metodos
        //obtenerSede()
    }
}
