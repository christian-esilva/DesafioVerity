using MediatR;
using System;

namespace DesafioVerity.Dominio.Handlers
{
    public class RequisicaoCredito : IRequest<RespostaCredito>
    {
        public Guid TitularContaId { get; set; }
        public decimal Valor { get; set; }
    }
}
