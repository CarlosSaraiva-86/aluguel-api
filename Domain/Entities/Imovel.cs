using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Imovel : Base
    {
        public int area { get; set; }
        public int terreno { get; set; }
        public int numQuartos { get; set; }
        public int numBanheiro { get; set; }
        public string andar { get; set; }
        public int vagas { get; set; }
        public string urlImagem { get; set; }
        public Proprietario proprietario { get; set; }
        public Endereco endereco { get; set; }
    }
}
