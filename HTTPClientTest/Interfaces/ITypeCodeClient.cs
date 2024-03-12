using TypeCodeIt11.Logic.Models;


namespace TypeCodeIt11.Logic.Interfaces
{
    public interface ITypeCodeClient
    {
        Task<List<User>> GetUsers(string name);
        Task<List<Post>> GetPost (int userID);
        Task<List<Comment>> GetComments(int postId);

    }
}
