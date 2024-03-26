using TypeCodeIt11.Logic.Interfaces;

namespace TypeCodeIt11.Logic.Models.Requests
{
    public class GetPhotoRequest : IRequestData
    {
        public GetPhotoRequest(int albumId)
        {
                AlbumId = albumId;
        }
        public int AlbumId { get; set; }


        public string GetData()
        {
            string result = "photos";
            if (AlbumId > 0)
            {
                result += $"?albumId={AlbumId}";
            }
            return result;
        }
    }
}
