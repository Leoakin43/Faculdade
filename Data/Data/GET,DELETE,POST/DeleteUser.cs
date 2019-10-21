using System;
using System.Net.Http;

namespace Data
{
    class DeleteUser
    {
        Url U = new Url();

        public bool DeleteUsers(string del)
        {
            string action = string.Format("/People('{0}')", del);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, U.Url_ + action);

            HttpResponseMessage response = HttpInstance.HttpClientInstance().SendAsync(request).Result;

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            string returnValue = response.Content.ReadAsStringAsync().Result;

            throw new Exception($"Falha ao Deletar: ({response.StatusCode}): {returnValue}");

        }
    }
}
