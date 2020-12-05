using LojaApi.Models;
using System.Threading.Tasks;

namespace LojaApi.Interfaces
{
    public interface ICompraService
    {
        Task<object> Efetivar(CompraRequest compraRequest);
    }
}
