using System;

namespace HTTPClientTest.Requests
{
    public class GetUserRequest : IRequest
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        public string GetRquestData()
        {
            string result = string.Empty;
            if(Id > 0)
            {
                result += $"id={Id}";
            }
            if (!string.IsNullOrEmpty(Name))
            {
                result += $"name={Name}";
            }
            if (!string.IsNullOrEmpty(UserName))
            {
                result += $"UserName={UserName}";
            }
            return result;  
        }
    }
}
