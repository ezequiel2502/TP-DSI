using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_DSI.BackEnd;

namespace TP_DSI.Datos
{
    class Usuario
    {
        private DateTime caducidad;
        private string contraseña;
        private int id_empleado;
        private int id_usuario;
        private string nombre;

        public DateTime Caducidad { get => caducidad; set => caducidad = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        //METODOS
        public int obtenerEmpleado(string nombre, string clave)
        {
            string consultaSql = "SELECT * FROM  Usuario WHERE nombre = '" + nombre + "'AND contraseña = '" + clave + "'";
            DataTable tabla = new DataTable();

            BE_Acceso_Datos be = new BE_Acceso_Datos();
            tabla = be.consultar(consultaSql);

            if(tabla.Rows.Count > 0)
            {
               return Convert.ToInt32(tabla.Rows[0][0]);
            }
            else
            {
                return 0;
            }
        }
    }
}
