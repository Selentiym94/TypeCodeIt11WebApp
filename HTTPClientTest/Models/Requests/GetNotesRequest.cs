using TypeCodeIt11.Logic.Interfaces;

namespace TypeCodeIt11.Logic.Models.Requests
{
    public class GetNotesRequest : IRequestData
    {
        public int UserId { get; set; }

        public GetNotesRequest(int userId)
        {
                UserId = userId;
        }

        public string GetData()
        {
            string result = "todos";
            if (UserId > 0)
            {
                result += $"?userId={UserId}";
            }
            return result;
        }
    }
}
