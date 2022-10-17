using SQLBaglanti.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBaglanti.Controller
{
    public static class ProcessController
    {
        public static List<Process> GetAll()
        {
            List<Process> list1 = new List<Process>();
            //ADO.NET Commands, ORM araclari
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select * From Processes", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Process process = new Process();
                process.Id = (int)dr["Id"];
               process.Name = dr["Name"].ToString();
              process.Price = (float)(decimal)dr["Price"];
            list1.Add(process);
            }
            conn.Close();
            return list1;
        }
    }
}
