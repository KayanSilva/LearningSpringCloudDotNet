using LojaApi.Models;
using System.Threading.Tasks;

namespace LojaApi.Interfaces
{
    public interface IFornecedorRepository
    {
        Task<InfoFornecedorResponse> ObterInformacoes(string estado);
    }
}