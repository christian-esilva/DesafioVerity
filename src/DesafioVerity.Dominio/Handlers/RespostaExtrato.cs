using DesafioVerity.Dominio.Handlers.Base;
using System;
using System.Collections.Generic;

namespace DesafioVerity.Dominio.Handlers
{
    public class RespostaExtrato : RespostaBase
    {
        public RespostaExtrato()
        {
            Detalhes = new List<ItemExtrato>();
        }

        public decimal Valor { get; set; }
        public IList<ItemExtrato> Detalhes { get; set; }

        public class ItemExtrato
        {
            public DateTime Data { get; set; }
            public decimal Valor { get; set; }
            public string TipoTransacao { get; set; }
        }
    }
}
