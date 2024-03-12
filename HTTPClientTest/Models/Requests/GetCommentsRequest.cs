using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeCodeIt11.Logic.Interfaces;

namespace TypeCodeIt11.Logic.Models.Requests
{
    public class GetCommentsRequest : IRequestData
    {
        public int PostId { get; set; }

        public GetCommentsRequest(int postId)
        {
            PostId = postId;
        }

        public string GetData()
        {
            throw new NotImplementedException();
        }
    }
}
