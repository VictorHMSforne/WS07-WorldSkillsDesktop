using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //adicionado
using System.Data.SqlClient; //adicionado
using System.Windows.Forms;

namespace WS
{

    public class Pressao
    {
        public int Id { get; set; }
        public int Sistole { get; set; }
        public int Diastole { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\Desk\\WS\\WS\\DbPressao.mdf;Integrated Security=True");

        public List<Pressao> listarPressao()
        {
            List<Pressao> li = new List<Pressao>();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            string sql = "SELECT * FROM Pressao";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pressao pressao = new Pressao();
                pressao.Id = (int)dr["Id"] ;
                pressao.Sistole = (int)dr["Sistole"];
                pressao.Diastole = (int)dr["Diastole"]; ;
                pressao.Data = dr["Data"].ToString();
                pressao.Hora = dr["Hora"].ToString();
                li.Add(pressao);

            }
            con.Close();
            return li;

        }
        public void Inserir(int Sistole, int Diastole)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                string Data = DateTime.Now.ToString("dd/MM/yyyy");
                string Hora = DateTime.Now.ToString("HH:mm");
                string sql = "INSERT INTO Pressao(Sistole,Diastole,Data,Hora) VALUES('" + Sistole + "','" + Diastole + "','" + Data + "','" + Hora + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro");
            }
        }

        public object MediaSis()
        {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                string sql = "SELECT avg(Sistole) FROM Pressao";
                SqlCommand cmd = new SqlCommand(sql, con);
                var result = cmd.ExecuteScalar();
                return result;
        }

        public object MediaDias()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            string sql = "SELECT avg(Diastole) FROM Pressao";
            SqlCommand cmd = new SqlCommand(sql, con);
            var result = cmd.ExecuteScalar();
            return result;
        }
    }
    

    
}
