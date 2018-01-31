using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkaMvc.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        
        public string Nimi { get; set; }
        public string Osoite { get; set; }
    }
}
