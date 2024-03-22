using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FindMate.Models;
using Newtonsoft.Json;

namespace FindMate.Rest
{
    public class ApiService
    {
        private HttpClient _client;

        public ApiService()
        {
            _client = new HttpClient();
        }
        public async Task<string> CreateUsuariosAsync(object user)
        {
            string json;

            // Verificar si el parámetro es un objeto Usuario o una cadena JSON
            if (user is Usuario)
            {
                // Si es un objeto Usuario, serializarlo a JSON
                json = JsonConvert.SerializeObject(user);
            }
            else if (user is string)
            {
                // Si es una cadena JSON, usarla directamente
                json = (string)user;
            }
            else
            {
                // Si no es ni un objeto Usuario ni una cadena JSON, lanzar una excepción
                throw new ArgumentException("El parámetro debe ser un objeto Usuario o una cadena JSON.");
            }

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(ApiConfig.CreateUserEndpoint, content);
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return responseData;
            }
            else
            {
                return null;
            }
        }

    }
}
