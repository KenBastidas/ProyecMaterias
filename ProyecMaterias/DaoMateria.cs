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
        private static string cadenaConexion = @"Server=LAPTOP-KEN\SQLEXPRESS; database=Materias; integrated security=true";
        public static int create(Materias matter)
        {
            
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
       

        public static int actualizar(Materias matter)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);


            string sql = "update Estudiantes set IDMateria=@IDMateria, NameMateria=@NameMateria, " +
                "Nivel=@Nivel, Carrera=@Carrera " +
                "where IDMateria=@IDMateria";

            //
            SqlCommand comando = new SqlCommand(sql, conexion);

            //definir los parametros
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@IDMateria", matter.IDMateria);
            comando.Parameters.AddWithValue("@NameMateria", matter.NameMateria);
            comando.Parameters.AddWithValue("@Nivel", matter.Nivel);
            comando.Parameters.AddWithValue("@Carrera", matter.Carrera);

            //
            conexion.Open();
            int x = comando.ExecuteNonQuery();//devuelve el total de filas modificadas
            //
            conexion.Close();

            return x;
        }
 

        public static int eliminar(String IDMateria)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);


            string sql = "delete from Estudiantes " +
                "where IDMateria=@IDMateria ";

            //
            SqlCommand comando = new SqlCommand(sql, conexion);

            //definir los parametros
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@IDMateria", IDMateria);


            //
            conexion.Open();
            int x = comando.ExecuteNonQuery();//devuelve el total de filas modificadas
            //
            conexion.Close();

            return x;
        }
        public static DataTable getAll()
        {
            //string cadenaConexion = @"Server=LAPTOP-KEN\SQLEXPRESS; database=Materias; integrated security=true";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            string sql = "select IDMateria, NameMateria, Nivel, Carrera" + " from Estudiantes order by IDMateria, NameMateria";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public static Materias GetMateria(String IDMateria)
        {
            //cadena de conmexion tulizando el suahrio de windows
            //string cadenaConexion = @"Server=LAPTOP-KEN\SQLEXPRESS; database=Materias; integrated security=true";
            //definir un obejto tipo conexion para coenctarnos al servidor
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            //2. Deinfir la operaciona  relizar en el servidor
            //operacio: obetener todos lso resgistros.
            //sql(lenguaje estruturadod e conulstas)
            string sql = "select IDMateria ,NameMateria , Nivel, Carrera " +
                "from Estudiantes " +
                "where IDMateria=@IDMateria";

            //definir un adaptador de datos: es un puerte que permite pasar los datos de la BDD hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);
            //pasar el parametro
            ad.SelectCommand.Parameters.AddWithValue("@IDMateria", IDMateria);
            //3. recuperamos lso datos
            DataTable dt = new DataTable();
            ad.Fill(dt);
            Materias p = new Materias();
            p.IDMateria = "";
            p.NameMateria = "";
            p.Nivel = 0;
            p.Carrera = "";
            //recorrer el datatable
            foreach (DataRow fila in dt.Rows)
            {
                p.IDMateria = fila["IDMateria"].ToString();
                p.NameMateria = fila["NameMateria"].ToString();
                p.Nivel = int.Parse(fila["Nivel"].ToString());
                p.Carrera = fila["Carrera"].ToString();
                break;
            }
            return p;
        }

    }
}
