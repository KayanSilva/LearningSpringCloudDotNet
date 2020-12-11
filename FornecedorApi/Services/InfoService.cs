using FornecedorApi.Interfaces;
using FornecedorApi.Models;

namespace FornecedorApi.Services
{
    public class InfoService : IInfoService
    {
        private readonly IInfoRepository _infoRepository;

        public InfoService(IInfoRepository infoRepository)
        {
            _infoRepository = infoRepository;
        }

        public InfoFornecedor PorEstado(string estado)
        {
            return _infoRepository.FindByEstado(estado);
        }
    }
}