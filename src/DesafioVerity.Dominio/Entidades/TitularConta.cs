using System.Collections.Generic;

namespace DesafioVerity.Dominio.Entidades
{
    public class TitularConta : Entidade
    {
        public string Nome { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string Senha { get; set; }
        public virtual Conta Conta { get; set; }
        public virtual ICollection<Extrato> Extratos { get; set; }
    }
}
