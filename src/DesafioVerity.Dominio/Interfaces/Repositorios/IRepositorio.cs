using DesafioVerity.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioVerity.Dominio.Interfaces.Repositorios
{
    public interface IRepositorio<TEntidade> : IDisposable where TEntidade : Entidade
    {
        Task<TEntidade> ObterPorId(Guid id);
        Task<int> SaveChanges();
        Task<List<TEntidade>> ObterTodos();
    }
}
