using System;

namespace DesafioVerity.Dominio.Entidades
{
    public class Conta : Entidade
    {
        public Guid TitularContaId { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataHoraAlteracao { get; set; }
        public virtual TitularConta TitularConta { get; set; }
    }
}
