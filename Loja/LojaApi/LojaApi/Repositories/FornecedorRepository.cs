using LojaApi.Interfaces;
using LojaApi.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace LojaApi.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly HttpClient _httpClient;

        public FornecedorRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<InfoFornecedorResponse> ObterInformacoes(string estado)
        {
            var retorno = await _httpClient.GetAsync($"info/{estado}");
            return JsonSerializer.Deserialize<InfoFornecedorResponse>(await retorno.Content.ReadAsStringAsync());
        }
    }
}
