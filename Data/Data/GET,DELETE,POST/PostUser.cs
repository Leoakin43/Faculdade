using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Data
{
    class PostUser
    {
        Url U = new Url();

        public bool PostUsers(object json)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(json), System.Text.Encoding.UTF8, "application/json"))
            {
                string action = string.Format("/People");

                HttpResponseMessage result = HttpInstance.HttpClientInstance().PostAsync(U.Url_ + action, content).Result;

                if (result.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    return true;
                }

                string returnValue = result.Content.ReadAsStringAsync().Result;

                throw new Exception($"Falha ao Postar data: ({result.StatusCode}): {returnValue}");
            }
        }
    }
}
