using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; } //public can be get or set from any other class in our application 
        public string UserName { get; set; }

        
    }
}