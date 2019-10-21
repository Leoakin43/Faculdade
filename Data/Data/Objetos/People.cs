using System.Collections.Generic;

namespace Data
{
    public class People
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Emails = new List<string>();
    }
}
