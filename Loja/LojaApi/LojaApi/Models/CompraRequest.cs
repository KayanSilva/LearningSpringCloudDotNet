using System.Collections.Generic;

namespace LojaApi.Models
{
    public class CompraRequest
    {
        public IList<ItemCompra> Itens { get; set; }
        public Endereco Endereco { get; set; }
    }
}
