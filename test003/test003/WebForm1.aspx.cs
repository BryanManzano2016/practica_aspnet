using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using test003.src;

namespace test003
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            Label1.Text = DateTime.Today.ToString("d");
        }

        protected void Enviar_Click(object sender, EventArgs e) {
            if( nombre.Text.Equals("") || edad.Text.Equals("") || cedula.Text.Equals(""))
            {
                resultado_consulta.Text = "Ingrese todos los campos.";
            } else
            {
                resultado_consulta.Text = "Ingreso...";
                string configuracion = new Funciones().Configuracion_Db("conexion_1");
                SqlConnection conexion = new SqlConnection(configuracion);
                conexion.Open();

                SqlCommand sql = new SqlCommand( String.Format("INSERT INTO usuarios(cedula, nombre, edad) " +
                    "VALUES('{0}', '{1}', '{2}')", cedula.Text.ToString(),
                    nombre.Text.ToString(), int.Parse( edad.Text.ToString()) ), conexion);
                
                if (sql.ExecuteNonQuery() > 0)
                {
                    resultado_consulta.Text = "Excelente, sus datos fueron ingresados.";
                }

                conexion.Close();
            }
        }

    }
}