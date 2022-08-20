using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Emergency_Hospital
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-27S4QM7SQLEXPRESS; DATABASE=Emergency_Hospital; Integrated security=true");

            cn.Open();
            return cn;
            }
        }
    }
