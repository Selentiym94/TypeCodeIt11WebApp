using TypeCodeIt11.Logic.Models;


namespace TypeCodeIt11.Logic.Interfaces
{
    public interface ITypeCodeClient
    {
        Task<List<User>> GetUsers(string name);
        Task<List<Post>> GetPost (int userId);
        Task<List<Comment>> GetComments(int postId);
        Task<List<Album>> GetAlbums(int userId);
        Task<List<Photo>> GetPhotos(int albumId);
        Task<List<Note>> GetNotes(int userId);

    }
}
