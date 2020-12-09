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

        public async Task<object> Efetivar(CompraRequest compraRequest)
        {
            return await _fornecedorRepository.ObterInformacoes(compraRequest.Endereco.Estado);
        }
    }
}