using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class Corso
    {
        public string Nome { get; set; }
        public int Numedizione { get; set; }
        public List<Lezione> Lezioni { get; set; }
        public  List<Studente> Studenti { get; set; }
        public int numerostudenti { get; set; }
    }
}
