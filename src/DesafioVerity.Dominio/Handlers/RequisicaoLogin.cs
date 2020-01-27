using MediatR;

namespace DesafioVerity.Dominio.Handlers
{
    public class RequisicaoLogin : IRequest<RespostaLogin>
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string Senha { get; set; }
    }
}
