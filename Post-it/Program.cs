using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PostIt p1 = new PostIt("Sárga");
            PostIt p2 = new PostIt("Piros");
            PostIt p3 = new PostIt("Zöld");

            p1.HozzaAdas("Jónapot!");
            Console.WriteLine(p2);
            p2.HozzaAdas("Egyszer volt, hol nem volt, egy apró faluban élt egy öreg cipész, akit mindenki tisztelt mestersége miatt. Egy napon különös vendég érkezett hozzá, egy vándor, aki egy pár cipőt kért tőle, de nem akármilyet: olyat, amely képes elvezetni viselőjét az igazság földjére. A cipész, bár csodálkozott a kéréseken, elfogadta a kihívást, és napokon át dolgozott a műhelyében. Végül elkészítette a cipőt, mely ragyogott a napfényben, mintha varázslat szőtte volna. A vándor hálásan megköszönte, felhúzta a cipőt, és elindult. A faluban mindenki emlékezett a napra, amikor a cipész álomból valóságot alkotott, és a legenda örökre fennmaradt.");
            p3.HozzaAdas("Alma");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
