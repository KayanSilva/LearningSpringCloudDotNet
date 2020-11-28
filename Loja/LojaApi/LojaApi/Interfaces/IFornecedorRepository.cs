using System.Threading.Tasks;

namespace LojaApi.Interfaces
{
    public interface IFornecedorRepository
    {
        Task<object> ObterInformacoes(string estado);
    }
}
