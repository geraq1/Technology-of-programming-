using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class products
    {

        public class Tovari
        {
            [Key]
            public int kod { get; set; }

            public string nazvanie { get; set; }

            public int? kol_vo { get; set; }

            public int? price { get; set; }

            public int? obshaya_stoimost { get; set; }

        }
    }
}

        


