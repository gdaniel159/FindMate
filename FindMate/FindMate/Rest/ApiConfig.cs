using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FindMate.Rest
{
    public class ApiConfig
    {
        private const string BaseUrl = "https://app-server-findmate.000webhostapp.com/api";

        public static string TipoUsuarioEndpoint => $"{BaseUrl}/tipousuario";
        public static string GetAllTipoUsuarioEndpoint => $"{TipoUsuarioEndpoint}/get";
        public static string GetTipoUsuarioByIdEndpoint(int id) => $"{TipoUsuarioEndpoint}/get/{id}";
        public static string CreateTipoUsuarioEndpoint => $"{TipoUsuarioEndpoint}/create";
        public static string UpdateTipoUsuarioEndpoint(int idTipoUsuario) => $"{TipoUsuarioEndpoint}/update/{idTipoUsuario}";

        public static string UserEndpoint => $"{BaseUrl}/user";
        public static string LoginEndpoint => $"{UserEndpoint}/login";
        public static string GetAllUserEndpoint => $"{UserEndpoint}/get";
        public static string GetUserByIdEndpoint(int id) => $"{UserEndpoint}/get/{id}";
        public static string CreateUserEndpoint => $"{UserEndpoint}/create";
        public static string LogoutEndpoint => $"{UserEndpoint}/logout";
    }
}
