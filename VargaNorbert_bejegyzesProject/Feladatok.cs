using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VargaNorbert_bejegyzesProject
{
    internal class Feladatok
    {
        private List<Bejegyzes> bejegyzes;
        private List<Bejegyzes> bejegyzes2;
        public Feladatok() 
        {
            bejegyzes = new List<Bejegyzes>();
            bejegyzes2= new List<Bejegyzes>();
            hozzaad();
            beolvas();
            likeosztas();
            szoveg();
            kiiratas();
            for (int i = 0; i < bejegyzes.Count; i++)
            {
                Console.WriteLine(bejegyzes[i]);
            }
            for (int i = 0; i < bejegyzes.Count; i++)
            {
                Console.WriteLine(bejegyzes2[i]);
            }
        }
        private void hozzaad()
        {
            int bejegyszam;
            Console.WriteLine("Kérek egy számot hány darab bejegyzést fog írni :");
            bejegyszam = Convert.ToInt32(Console.ReadLine());
            if (bejegyszam < 0)
            {
                Console.WriteLine("Természetes számot kérek");
            }
            else
            {
                for (int i = 0; i < bejegyszam; i++)
                {
                    Console.WriteLine("Adjon meg szerzőt: ");
                    string szerzo = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Adjon meg a tartalmat: ");
                    string tartalom = Convert.ToString(Console.ReadLine());
                    Bejegyzes b1 = new Bejegyzes(szerzo, tartalom);
                    bejegyzes.Add(b1);

                    

                }
                Console.WriteLine(bejegyzes.Count);
            }

        }
        private void beolvas()
        {
            StreamReader r = new StreamReader("bejegyzesek.csv");
            
            while (!r.EndOfStream) 
            {
                string[] adatok = r.ReadLine().Split(';');
                string szerzo = adatok[0];
                string tartalom= adatok[1];
                Bejegyzes b = new Bejegyzes(szerzo, tartalom);
                bejegyzes2.Add(b);
                
            }
            
        }
        private void likeosztas() 
        {
            
            Random r=new Random();
            int szam;
            for (int i = 0; i < bejegyzes.Count*20; i++)
            {
                szam=r.Next(0, bejegyzes.Count);

                bejegyzes[szam].Likeok();
            }
            for (int i = 0; i < bejegyzes.Count; i++)
            {
                Console.WriteLine(bejegyzes[i].ToString());
            }
        }

        private void szoveg() 
        {
            Console.WriteLine("Kérek egy szöveget: ");
            string szoveg = Convert.ToString(Console.ReadLine());
            bejegyzes2[1].Tartalom = szoveg;
            Console.WriteLine();

            Console.WriteLine(bejegyzes2[1].ToString());

        }
       
    }
}
