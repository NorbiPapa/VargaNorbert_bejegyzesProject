using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VargaNorbert_bejegyzesProject
{
    internal class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int like;
        new DateTime letrejott;
        new DateTime szerkeztve;
        

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.like = 0;
            this.letrejott = DateTime.Today;
            this.szerkeztve = DateTime.Today;
        }
        
        
        public string Szerzo { get => szerzo; }
        public string Tartalom { get => tartalom; set => tartalom = value;}
        public int Like { get => like;}
        public DateTime Letrejott { get => letrejott;}
        public DateTime Szerkeztve { get => szerkeztve;}

        public void Likeok() 
        {
            this.like++;
        }
        public override string ToString()
        {
            if (this.letrejott!=this.szerkeztve)
            {
                return $"{this.szerzo}-{this.like}-{this.letrejott}\n Szerkeztve: {this.szerkeztve}\n {this.tartalom}";
            }
            else
            {
                return $"{this.szerzo}-{this.like}-{this.letrejott}\n {this.tartalom}";
            }
            
            
        }
        
        
       

    }
}
