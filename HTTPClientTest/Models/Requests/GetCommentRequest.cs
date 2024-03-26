using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeCodeIt11.Logic.Interfaces;

namespace TypeCodeIt11.Logic.Models.Requests
{
    public class GetCommentRequest : IRequestData
    {
        public int PostId { get; set; }

        public GetCommentRequest(int postId)
        {
            PostId = postId;
        }

        public string GetData()
        {
            string result = "comments";
            if (PostId > 0)
            {
                result += $"?postId={PostId}";
            }
            return result;
        }
    }
}
