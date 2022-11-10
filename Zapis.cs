using System.ComponentModel.DataAnnotations;

namespace Gerchik
{
    public class Zapis
    {
        [Key]
        public int kod { get; set; }

        public int? klient { get; set; }

        public int? tovar { get; set; }

        public int? sotrudnik { get; set; }

        public int? usluga { get; set; }

        public DateTime? data { get; set; }

        public int? adressalona { get; set; }

    }
}
