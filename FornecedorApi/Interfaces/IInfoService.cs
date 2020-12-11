using FornecedorApi.Models;

namespace FornecedorApi.Interfaces
{
    public interface IInfoService
    {
        InfoFornecedor PorEstado(string estado);
    }
}