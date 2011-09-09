using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort.Dominio
{
    public class Endereco: EntidadeBase
    {
        public override int Id { get; set; }

        public virtual string Endereco { get; set; }

        public virtual int Numero { get; set; }

        public virtual string Bairro { get; set; }

        public virtual string Cidade { get; set; }

        public virtual string Estado { get; set; }

        public virtual string Cep { get; set; }

    }
}
