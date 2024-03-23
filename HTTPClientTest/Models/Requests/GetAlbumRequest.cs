using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeCodeIt11.Logic.Interfaces;

namespace TypeCodeIt11.Logic.Models.Requests
{
    public class GetAlbumRequest : IRequestData
    {
        public int UserId { get; set; }

        public GetAlbumRequest(int userId)
        {
            UserId = userId;
        }

        public string GetData()
        {
            string result = "albums";
            if (UserId > 0)
            {
                result += $"?userId={UserId}";
            }
            return result;
        }
    }
}
