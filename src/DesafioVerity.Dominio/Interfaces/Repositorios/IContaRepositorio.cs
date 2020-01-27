using DesafioVerity.Dominio.Entidades;
using System.Threading.Tasks;

namespace DesafioVerity.Dominio.Interfaces.Repositorios
{
    public interface IContaRepositorio : IRepositorio<Conta>
    {
        Task Alterar(Conta conta);
    }
}
