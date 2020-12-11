using FornecedorApi.Models;

namespace FornecedorApi.Interfaces
{
    public interface IInfoRepository
    {
        InfoFornecedor FindByEstado(string estado);
    }
}