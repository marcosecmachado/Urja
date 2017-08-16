using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrjaSacial.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public DateTime Dt_cadastro { get; set; }
        public String Nome { get; set; }
        public String Catrgoria { get; set; }
        public Decimal Preco { get; set; }
    }
}