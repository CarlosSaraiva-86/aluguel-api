using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Endereco : Base
    {
        public string endereco { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
    }
}
