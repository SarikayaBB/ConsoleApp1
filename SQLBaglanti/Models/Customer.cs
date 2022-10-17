using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBaglanti.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public bool IsDeleted { get; set; }
    }      
}
