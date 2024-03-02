using HTTPClientTest.Models;
using HTTPClientTest.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HTTPClientTest
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            TypeCodeClient client = new TypeCodeClient("https://jsonplaceholder.typicode.com");

            GetUserRequest request = new GetUserRequest();
            request.Name = "Chelsey Dietrich";

            List<User> users = await client.GetUsers(request).ConfigureAwait(false);
            Console.ReadLine();
        }
    }
}
    