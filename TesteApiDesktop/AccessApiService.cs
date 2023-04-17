using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TesteApiDesktop
{
    public class AccessApiService
    {
        public async Task<List<Venda>> GetVendaDiaAnterior(AccessToken accessToken)
        {
            using(var client = new HttpClient())
            {
                GetHeaderTokenAuthorization(client, accessToken);

                using(var response = await client.GetAsync(("http://192.168.7.135:5000/api/v1/Venda")))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var VendaJsonString = await response.Content.ReadAsStringAsync();
                        List<Venda> vendas = JsonConvert.DeserializeObject<Venda[]>(VendaJsonString).ToList();
                        return vendas;
                    }
                    else
                    {
                        throw new Exception("Não foi possível obter as vendas: " + response.StatusCode);
                    }
                }               

            }
        }

        public async Task<List<Venda>> GetVendaPorData(AccessToken accessToken, string dataInicio, string dataFinal)
        {
            using (var client = new HttpClient())
            {
                GetHeaderTokenAuthorization(client, accessToken);

                using (var response = await client.GetAsync(("http://192.168.7.135:5000/api/v1/Venda/"+dataInicio+"/"+dataFinal)))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var VendaJsonString = await response.Content.ReadAsStringAsync();
                        List<Venda> vendas = JsonConvert.DeserializeObject<Venda[]>(VendaJsonString).ToList();
                        return vendas;
                    }
                    else
                    {
                        throw new Exception("Não foi possível obter as vendas: " + response.StatusCode);
                    }
                }

            }
        }

        public async Task<List<DevolucaoDTO>> Devolucao15dias(AccessToken accessToken)
        {
            using (var client = new HttpClient())
            {
                GetHeaderTokenAuthorization(client, accessToken);

                using (var response = await client.GetAsync(("http://192.168.7.135:5000/api/Devolucao")))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var DevolucaoJsonString = await response.Content.ReadAsStringAsync();
                        List<DevolucaoDTO> devolucoes = JsonConvert.DeserializeObject<DevolucaoDTO[]>(DevolucaoJsonString).ToList();
                        return devolucoes;
                    }
                    else
                    {
                        throw new Exception("Não foi possível obter as devolucoes: " + response.StatusCode);
                    }
                }

            }
        }

        public static void GetHeaderTokenAuthorization(HttpClient client, AccessToken accessToken)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", accessToken.Token);
        }
    }
}
