using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TypeCodeIt11.Logic.Interfaces;

namespace TypeCodeIt11.Logic.Models.Requests
{
    public class GetPostRequest : IRequestData
    {
        public GetPostRequest(int userId)
        {
              UserId = userId;   
        }
        public int UserId { get; set; }

        public string GetData()
        {
            string result = "posts";
            if (UserId > 0)
            {
                result += $"?userId={UserId}";   
            }
            return result;
            
           
        }
    }
}














    

