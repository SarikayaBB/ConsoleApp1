using SQLBaglanti.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBaglanti.Controller
{
    public static class CustomerController
    {
        public static List<Customer> GetAll()
        {
            List<Customer> list = new List<Customer>();
            //ADO.NET Commands, ORM araclari
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select * From Customers", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Customer customer = new Customer();
                customer.Id = (int)dr["Id"];
                customer.Guid = dr["Guid"].ToString();
                customer.Name = dr["Name"].ToString();
                customer.Tel = dr["Tel"].ToString();
                customer.IsDeleted = (bool)dr["isDeleted"];
                list.Add(customer);
            }
            conn.Close();
            return list;
        }

    }
}
