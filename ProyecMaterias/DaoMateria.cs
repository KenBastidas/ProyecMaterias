using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyecMaterias
{
    public class DaoMateria
    {
        public static int create(Materias matter)
        {
            string cadenaConexion = @"Server=LAPTOP-KEN\SQLEXPRESS; database=Materias; integrated security=true";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            string sql = "insert into Estudiantes(IDMateria, NameMateria, Nivel, Carrera )"
                + "values(@IDMateria, @NameMateria, @Nivel, @Carrera )";

            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@IDMateria", matter.IDMateria);
            comando.Parameters.AddWithValue("@NameMateria", matter.NameMateria);
            comando.Parameters.AddWithValue("@Nivel", matter.Nivel);
            comando.Parameters.AddWithValue("@Carrera", matter.Carrera);

            conexion.Open();
            int x = comando.ExecuteNonQuery();

            conexion.Close();

            return x;
        }
        public static DataTable getAll()
        {
            string cadenaConexion = @"Server=LAPTOP-KEN\SQLEXPRESS; database=Materias; integrated security=true";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            string sql = "select IDMateria, NameMateria, Nivel, Carrera" + " from Estudiantes";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
