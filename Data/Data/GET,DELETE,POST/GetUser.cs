using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;

namespace Data
{
    public class GetUser
    {
        Url U = new Url();

        public List<People> GetUsers(string UserName)
        {
            string action = string.Format("/People?$filter=contains(UserName, '{0}')", UserName);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, U.Url_ + action);

            HttpResponseMessage response = HttpInstance.HttpClientInstance().SendAsync(request).Result;

            List<People> User = new List<People>();

            JArray UserJson = (JArray)JObject.Parse(response.Content.ReadAsStringAsync().Result)["value"];

            foreach (var UsersJson in UserJson)
            {
                User.Add(new People() { FirstName = UsersJson["FirstName"].ToString(), LastName = UsersJson["LastName"].ToString() });
            }
            return User;
        }
    }
}
