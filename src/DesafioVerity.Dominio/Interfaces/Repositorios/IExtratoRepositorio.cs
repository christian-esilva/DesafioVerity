using DesafioVerity.Dominio.Entidades;
using System.Threading.Tasks;

namespace DesafioVerity.Dominio.Interfaces.Repositorios
{
    public interface IExtratoRepositorio : IRepositorio<Extrato>
    {
        Task Inserir(Extrato extrato);
    }
}
