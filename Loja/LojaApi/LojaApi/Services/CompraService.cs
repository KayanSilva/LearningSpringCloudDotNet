using LojaApi.Interfaces;
using LojaApi.Models;
using System.Threading.Tasks;

namespace LojaApi.Services
{
    public class CompraService : ICompraService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public CompraService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public Task Efetivar(CompraRequest compraRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}
