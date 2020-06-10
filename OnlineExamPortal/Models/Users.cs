using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamPortal.Models
{
    public class Users
    {
        public Users() {
            Console.WriteLine("Users model invoked");
        } //Default Constructor
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "firstname")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "lastname")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public bool Gender { get; set; }

        [JsonProperty(PropertyName = "mobile")]
        public long Mobile { get; set; }

        [JsonProperty(PropertyName = "pin")]
        public int Pin { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        [JsonProperty(PropertyName = "customfield1")]
        public string CustomField1 { get; set; }

        [JsonProperty(PropertyName = "customfield2")]
        public string CustomField2 { get; set; }

        [JsonProperty(PropertyName = "customfield3")]
        public string CustomField3 { get; set; }

    }
}
