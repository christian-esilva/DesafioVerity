using MediatR;
using System;

namespace DesafioVerity.Dominio.Handlers
{
    public class RequisicaoExtrato : IRequest<RespostaExtrato>
    {
        public Guid TitularContaId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
