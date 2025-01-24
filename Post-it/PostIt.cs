using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_it
{
    public class PostIt
    {
        private string szin;
        private string tartalom;

        public PostIt(string szin)
        {
            this.szin = szin;
            this.tartalom = "";
        }

        public string Szin { get => szin;}
        public string Tartalom { get => tartalom;}

        public string HozzaAdas(string szoveg)
        {
            string alap = this.tartalom;
            string modositott = alap + szoveg;
            if (modositott.Length > 100)
            {
                Console.WriteLine("Túl hosszú a szoveg! adjon meg egy másikat!");
                this.tartalom = alap;
                return this.tartalom;
            }
            else
            {
                this.tartalom = modositott;
                return this.tartalom;
            }
        }

        public int Hossz
        {
            get => this.tartalom.Length;
        }

        public override string ToString()
        {
            return $"szín: {this.szin}  tartalom: {this.tartalom}";
        }
    }
}
