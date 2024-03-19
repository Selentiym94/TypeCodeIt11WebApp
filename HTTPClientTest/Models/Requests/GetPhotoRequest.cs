using TypeCodeIt11.Logic.Interfaces;

namespace TypeCodeIt11.Logic.Models.Requests
{
    public class GetPhotoRequest : IRequestData
    {
        public GetPhotoRequest(int albutId)
        {
                AlbutId = albutId;
        }
        public int AlbutId { get; set; }


        public string GetData()
        {
            string result = "photos";
            if (AlbutId > 0)
            {
                result += $"?albumId={AlbutId}";
            }
            return result;
        }
    }
}
