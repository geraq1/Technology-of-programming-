using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Staff
    {
        public class Sotrudniki
        {
            [Key]
            public int kod { get; set; }

            public string familia { get; set; }

            public string imya { get; set; }

            public string otchestvo { get; set; }

            public int? telefon { get; set; }

            public string adres { get; set; }

            public string dolzhnost { get; set; }

        }
    }
}
