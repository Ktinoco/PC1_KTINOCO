using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Persistencia
{
    public class ConexionBD

    {
        public static string ObtenerCadena()
        {
           // return "Data Source=(local);Initial Catalog=BD_Asesores;Integrated Security=SSPI;";

            return "Data Source=e0d622b4-507d-4c19-b56d-a23901479e4a.sqlserver.sequelizer.com;Initial Catalog=dbe0d622b4507d4c19b56da23901479e4a; User Id=tudefpgozippbtqi;Password=2Z8EX7XVgwKMHgfVNiPs6cbqveT6Q3632bxUyHVW7tcYbJ8YnY53euvXXQjSm2en";
        }

    }
}