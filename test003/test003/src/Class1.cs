using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test003.src
{
    public class Funciones
    {
        public Funciones() { }

        public string Configuracion_Db(string nombre_configuracion)
        {
            return System.Configuration.ConfigurationManager.
                    ConnectionStrings[nombre_configuracion].ConnectionString;
        }
    }
}