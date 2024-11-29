using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CurrencyApp
{
    //Biblioteca para ler, pacote Newtonsoft.Json
    public class Currency
    {
        public static async Task<Dictionary<string, Dictionary<string, string>>> ObterCotacao()
        {
            // URL da API
            string url = "https://economia.awesomeapi.com.br/json/last/USD-BRL,EUR-BRL,BTC-BRL,JPY-BRL,CAD-BRl,DOGE-BRL,USD-CAD";
            // Configuração do cliente HTTP
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Envia a solicitação GET
                    HttpResponseMessage response = await client.GetAsync(url);
                    // Garante que a solicitação foi bem-sucedida
                    response.EnsureSuccessStatusCode();
                    // Lê a resposta como string
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // Deserializa o JSON em um dicionário
                    var cotacoes = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(jsonResponse);

                    return cotacoes;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Erro ao acessar a API: {ex.Message}");
                }
            }
        }
    }
}
