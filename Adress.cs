using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressalona 
{
    internal class Adress
    {
        public class Adressalona
        {
            [Key]
            public int kod { get; set; }

            public string adres_magazina { get; set; }

            public string reyting_magazina { get; set; }

            public string trrafic_klientov { get; set; }

        }
    }
}
