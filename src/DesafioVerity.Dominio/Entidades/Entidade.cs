using System;

namespace DesafioVerity.Dominio.Entidades
{
    public abstract class Entidade
    {
        public Guid Id { get; set; }
        public DateTime DataHoraCriacao { get; set; }
    }
}
