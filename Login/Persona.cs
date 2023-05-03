using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Persona
    {

        public string name { get; set; }
        public string password { get; set; }

        public Persona(string _name, string _password ) { 
        
            name = _name;
            password = _password;

        }
        
    }
}
