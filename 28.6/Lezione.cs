using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class Lezione
    {
        public string Descrizione { get; set; }
        public DateTime Data { get; set; }
        public string Orarioinizio { get; set; }
        public string durata { get; set; }
        public Docente docente { get; set; }
        public Aula aula { get; set; }
        public List<Studente> Studenti { get; set; }
        public int numerostudenti { get; set; }

        
        }
    }
}
