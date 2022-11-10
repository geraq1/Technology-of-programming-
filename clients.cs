using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klient
{
    internal class klient
    {
        public class Klient
        {
            [Key]
            public int kod { get; set; }

            public string familiya { get; set; }

            public string imya { get; set; }

            public string otchestvo { get; set; }

            public int? telefon { get; set; }

            public string adres { get; set; }

        }
    }
}
