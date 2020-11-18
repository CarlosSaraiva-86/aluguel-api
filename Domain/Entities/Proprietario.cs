using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Proprietario : Base
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public Endereco endereco { get; set; }
    }
}
