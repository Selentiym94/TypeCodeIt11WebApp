namespace TypeCodeIt11.Logic.Models
{
    public class AlbumDatas
    {
        public AlbumDatas(Album album, List<Photo> photos)
        {
            Album = album;
            Photos = photos;
        }
        public Album Album { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
