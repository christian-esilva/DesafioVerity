using DesafioVerity.Dominio.Enums;
using System;

namespace DesafioVerity.Dominio.Entidades
{
    public class Extrato : Entidade
    {
        public Guid TitularContaId { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataTransacao { get; set; }
        public ETipoTransacao TipoTransacao { get; set; }

        public virtual TitularConta TitularConta { get; set; }
    }
}
