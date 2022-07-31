using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DAO
{
        
    public class Dataprovider
    {
        private static Dataprovider instance;
       

        public static Dataprovider Instance {
            get {
                if (instance == null) instance = new Dataprovider(); return Dataprovider.instance;
            }
            private set {
                Dataprovider.instance = value; }
        }
        private Dataprovider() { }
        private string connectionSTR = "Data Source =.\\sqlexpress; Initial Catalog = DAQLGR; Integrated Security = True";

        public DataTable Execquery (String query , Object[] parameter = null)
         {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionSTR))
            {

                connect.Open();

                SqlCommand command = new SqlCommand(query, connect);

                if (parameter!=null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (String item in list)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item,parameter [i]);
                            i++;
                        }
                    }

                }
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connect.Close();
            }
           
            return data;
        }
        public int  Execnonquery(String query, Object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connect = new SqlConnection(connectionSTR))
            {

                connect.Open();

                SqlCommand command = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (String item in list)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }
                data = command.ExecuteNonQuery();
                connect.Close();
            }

            return data;
        }
        public object Execscalar(String query, Object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connect = new SqlConnection(connectionSTR))
            {

                connect.Open();

                SqlCommand command = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (String item in list)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                data = command.ExecuteScalar();
                connect.Close();
            }

            return data;
        }
    }
}
