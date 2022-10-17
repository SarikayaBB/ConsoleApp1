using SQLBaglanti.Controller;
using SQLBaglanti.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBaglanti
{
    internal class Program
    {
        static void Main(string[] args)
        {
           foreach (Customer customer in CustomerController.GetAll())
            {
                Console.Write(customer.Id + "\t" + customer.Guid + "\t" + customer.Name + "\t" + customer.Tel);
                Console.WriteLine();
            }
            foreach (Process process in ProcessController.GetAll())
            {
                Console.Write(process.Id + "\t" + process.Name + "\t" + process.Price);
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
