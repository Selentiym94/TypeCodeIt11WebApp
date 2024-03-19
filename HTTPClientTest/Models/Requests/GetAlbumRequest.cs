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
        public int UsertId { get; set; }

        public GetAlbumRequest(int usertId)
        {
            UsertId = usertId;
        }

        public string GetData()
        {
            string result = "albums";
            if (UsertId > 0)
            {
                result += $"?userId={UsertId}";
            }
            return result;
        }
    }
}
