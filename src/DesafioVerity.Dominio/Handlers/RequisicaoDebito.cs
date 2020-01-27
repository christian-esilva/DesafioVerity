using MediatR;
using System;

namespace DesafioVerity.Dominio.Handlers
{
    public class RequisicaoDebito : IRequest<RespostaDebito>
    {
        public Guid TitularContaId { get; set; }
        public decimal Valor { get; set; }
    }
}
