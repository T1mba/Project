using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vosmerochka_ry
{
    class connect
    {
        StreamReader sr;
        private string connectStringg;
        public MySqlConnection con;
        public MySqlDataAdapter adapter;

        public connect()
        {
            sr = new StreamReader("conect.txt");
            connectStringg = sr.ReadLine();
            return;
        }

        public DataSet CO(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new MySqlConnection(connectStringg);
                con.Open();
                adapter = new MySqlDataAdapter(query, con);
                ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
               
            }
            con.Close();
            return ds;
        }
        public void xa()
        {

        }

        public DataTable ConDT(string sql)
        {
            MySqlCommand cmd;
            MySqlDataReader dr;

            con = new MySqlConnection(connectStringg);
            con.Open(); //открываем БД
            DataTable dt = new DataTable();
            cmd = new MySqlCommand(sql, con);
            try
            {
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                con.Close(); //закрываем соединение, т.к. оно нам больше не нужно
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
            }
            return dt;
        }

    }

}
