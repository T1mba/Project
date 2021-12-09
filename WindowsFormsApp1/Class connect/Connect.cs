using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Class_connect
{
    public class Connect
    {

        public MySqlConnection con;
        public string connectString;
        public MySqlDataAdapter adapter;
        public MySqlDataReader dr;
        MySqlCommand cmd;
        StreamReader sr;
        public Connect()
        {
            sr = new StreamReader("stringConnect.ini");
            connectString = sr.ReadLine();
            connectString = "server=127.0.0.1;user=root;password=111111;database=vosmerka;sslmode=none";
        }
        public void ConnectClose()
        {
            con.Close();
        }
            public DataTable ConDt(string sql)
        {
            con = new MySqlConnection(connectString);
            con.Open();
            DataTable dt = new DataTable();
            cmd = new MySqlCommand(sql, con);
            try
            {
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataSet ConDS(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                con = new MySqlConnection(connectString);
                con.Open();
                adapter = new MySqlDataAdapter(sql, con);
                adapter.Fill(ds);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
        public void SIDU(string sql)
        {
            con = new MySqlConnection(connectString);
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            try
            {
                cmd2.CommandText = sql;
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Успешно");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string SEL(string sql)
        {
            DataTable dt = new DataTable();
            string s = "";
            con = new MySqlConnection(connectString);
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            try
            {
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText =  sql;
                MySqlDataReader dr1 = cmd2.ExecuteReader();
                while (dr1.Read())
                {
                    s = dr1.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                s = null;
            }
            return s;
        }
        public List<string> ListBD(string sql, int count_col)
        {
            List<string> l1 = new List<string>();
            con = new MySqlConnection(connectString);
            con.Open();
            MySqlCommand cmd2 = new MySqlCommand(sql,con);
            try
            {
                MySqlDataReader dr2 = cmd.ExecuteReader();
                dr2.Read();
                for(int i =0; i< count_col; i++)
                {
                    l1.Add(dr2.GetValue(i).ToString());
                }
                dr2.Close();
                con.Close();
            }
            catch(Exception ex)
            {

            }
            return l1;
        }
        public string[] MassBD(string sql, int count_col)
        {
            string[] m1 = new string[count_col];
            con = new MySqlConnection(connectString);
            con.Open();
            MySqlCommand cmd2 = new MySqlCommand(sql, con);
            try
            {
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                for(int i = 0; i < count_col; i++)
                {
                    m1[i] = dr2.GetValue(i).ToString();
                }
                dr2.Close();
                con.Close();
            }
            catch(Exception ex)
            {

            }
            return m1;
        }
        
    }
}
