using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AdultsClient.Models;
using Microsoft.AspNetCore.Connections;

namespace AdultsClient.Data
{
    public class UserWebService : IUserService
    {
        private string uri = "https://localhost:5001";
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;
        private IUserService _userServiceImplementation;

        public UserWebService()
        {
           
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            client = new HttpClient(clientHandler);  
        }
        public async Task<User> ValidateUserAsync(string username, string password)
        {
            Console.WriteLine("Validate user async");
            HttpResponseMessage response = await client.GetAsync($"{uri}/Users?username={username}&password={password}");
            Console.WriteLine(response.StatusCode);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                    string userAsJson = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(userAsJson);
                    User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
                    return resultUser;
            }
            else
            {
                Console.WriteLine(response.StatusCode);
                Console.WriteLine("Querry not ok");
            }
            throw new Exception("User not found");
        }

        public async Task<User> AddUser(User user)
        {
            string itemAsJson = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(
                itemAsJson, Encoding.UTF8, "application/Json");
            HttpResponseMessage responseMessage = await client.PostAsync($"{uri}/User", content);
            string result = await responseMessage.Content.ReadAsStringAsync();

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception(result);

            User newItem = JsonSerializer.Deserialize<User>(result, new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return newItem;
        }
    }
}