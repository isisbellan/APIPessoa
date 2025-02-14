using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Pessoa
{
    internal class API
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<JObject> BuscarInfoMoradiaAsync(string cep)
        {
            Erro.setErro(false);

            string url = $"https://viacep.com.br/ws/{cep}/json/";

            try
            {
                string response = await client.GetStringAsync(url);
                JObject dados   = JObject.Parse(response);

                if (dados.ContainsKey("erro") && dados["erro"].ToObject<bool>())
                {
                    Erro.setErro("CEP inválido. Tente novamente.");
                    return null;
                }

                return dados;
            }
            catch (Exception)
            {
                Erro.setErro($"Erro ao buscar informações do CEP. Tente novamente.");
                return null;
            }
        }
    }
}
