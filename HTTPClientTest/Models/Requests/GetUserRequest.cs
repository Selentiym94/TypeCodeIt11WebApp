using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TypeCodeIt11.Logic.Interfaces;

namespace TypeCodeIt11.Logic.Models.Requests
{
    public class GetUserRequest : IRequestData
    {
        public string Name { get; set; }
        public GetUserRequest(string name)
        {
            Name = name;
        }
        public string GetData()
        {
            string resualt = "users";
            if(!string.IsNullOrWhiteSpace(Name))
            {
                resualt += $"?name={Name}";
            }
            return resualt;
        }
    }
}
