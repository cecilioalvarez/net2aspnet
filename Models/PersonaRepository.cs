using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace net2.Models
{
    public class PersonaRepository
    {
        public List<Persona> BuscarTodas() {


            var sb = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "root",
                Port = 3306,
                Database = "curso2"
            };
            MySqlConnection conn = 
            new MySqlConnection(sb.ConnectionString);
            conn.Open();

            var comando = conn.CreateCommand();
            comando.CommandText = "select * from  Personas";
            var reader = 
            comando
            .ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            List<Persona> lista=new List<Persona>();
            while(reader.Read()) {


                Persona p= new Persona(reader.GetString("dni"),
                reader.GetString("nombre"),
                reader.GetString("apellidos"));
                lista.Add(p);

            }

            return lista;


        }






    }
}