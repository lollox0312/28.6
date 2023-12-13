using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edizione e=new Edizione();
            Corso c1=new Corso();
            Corso c2 = new Corso();
            Corso c3 = new Corso();
            c1.Nome = "scienze applicate";
            c2.Nome = "lingue";
            c3.Nome = "politica";
            e.Corsi.Add(c1);
            e.Corsi.Add(c2);
            e.Corsi.Add(c3);
           

            Lezione l1= new Lezione();  
            Lezione l2=new Lezione();
            Lezione l3=new Lezione();
            c1.Lezioni.Add(l1);
            c1.Lezioni.Add(l2);
            c1.Lezioni.Add(l3);

            Studente s1 = new Studente();
            Studente s2 = new Studente();
            Studente s3 = new Studente();          

            c1.Studenti.Add(s1);
            c1.Studenti.Add(s2);
            c1.Studenti.Add(s3);

            l1.Studenti.Add(s1);
            l1.Studenti.Add(s2);
            l1.Studenti.Add(s3);

            s1.Nome = "Gianni";
            s1.Cognome = "Leoni";
            s1.presenza = false;

            s2.Nome = "Sandro";
            s2.Cognome = "Sarti";
            s2.presenza = true;

            s3.Nome = "Aldo";
            s3.Cognome = "Baglio";
            s3.presenza = true;
         

            Console.ReadLine();
        }
    }
}
