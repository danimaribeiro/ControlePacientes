using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort.Dominio
{
    public class Clinicas: EntidadeBase
    {
        public override int Id { get; set; }

        public virtual int Codigo { get; set; }

        public virtual string Nome { get; set; }

        public virtual string NomeFantasia { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual string Cnpj { get; set; }
         
        public virtual string InscricaoEstadual { get; set; }

        public virtual string TelefoneClinica { get; set; }

    }
}
