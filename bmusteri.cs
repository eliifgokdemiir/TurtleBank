using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle_Bank
{
    public class bmusteri 
    {
        public int id_musteri { get; set; } 
        public string musteri_tc { get; set; }
        public string musteri_isim { get; set; }
        public string musteri_soyisim { get; set; }
        public string musteri_adres{ get; set; }
        public string musteri_email { get; set; }
        public decimal musteri_bakiye { get; set; }
        public decimal musteri_kredipuani { get; set; }  
        public DateTime musteri_dg { get; set; }
        public int id_tbanka { get; set; }


    }
}
