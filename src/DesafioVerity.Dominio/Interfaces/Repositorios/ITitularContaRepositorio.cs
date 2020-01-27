using DesafioVerity.Dominio.Entidades;
using DesafioVerity.Dominio.Handlers;
using System.Threading.Tasks;

namespace DesafioVerity.Dominio.Interfaces.Repositorios
{
    public interface ITitularContaRepositorio : IRepositorio<TitularConta>
    {
        Task<TitularConta> Login(RequisicaoLogin titularConta);
    }
}
