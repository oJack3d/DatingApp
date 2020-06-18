using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extentions
    {
        public static void AddApplicationError(this HttpResponse response, string message){
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Controll-Expose-Headers", "Aplication-Headers");
            response.Headers.Add("Access-Controll-Allow-Origin", "*");
        }
    }
}