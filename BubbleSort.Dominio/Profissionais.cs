using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort.Dominio
{
    public class Profissionais:EntidadeBase
    {
        public override int Id { get; set; }
        
        public virtual int Codigo { get; set; }

        public virtual string Nome { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual string Cpf { get; set; }

        public virtual string Rg { get; set; }

        public virtual string TelefoneFixo { get; set; }

        public virtual string TelefoneCelular { get; set; }

        public virtual DateTime DataNascimento { get; set; }
         
    }
}
