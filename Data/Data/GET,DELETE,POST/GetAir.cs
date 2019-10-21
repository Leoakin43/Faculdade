using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Data
{
    public class GetAir
    {
        Url U = new Url();

        public List<Airports> GetAirs(string airport)
        {
            string action = string.Format("/Airports?$filter=contains(Location/Address, '{0}')", airport);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, U.Url_ + action);

            HttpResponseMessage response = HttpInstance.HttpClientInstance().SendAsync(request).Result;

            List<Airports> Air = new List<Airports>();

            JArray AirJson = (JArray)JObject.Parse(response.Content.ReadAsStringAsync().Result)["value"];
            
            foreach (var AirsJson in AirJson)
            {
                Air.Add(new Airports() { Name = AirsJson["Name"].ToString(), IataCode = AirsJson["IataCode"].ToString() });
            }
            return Air;
        }
    }
}