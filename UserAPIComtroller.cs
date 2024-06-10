using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lorica_Residences_Rental_Management_System
{
    public class UserAPIController
    {
        public async void ProcessRequest(HttpListenerContext context)
        {
            context.Response.ContentType = "application/json";
            try
            {
                string json;
                using (var reader = new StreamReader(context.Request.InputStream))
                {
                    json = await reader.ReadToEndAsync();
                }

                var loginRequest = JsonConvert.DeserializeObject<LoginRequest>(json);

                if (loginRequest == null || string.IsNullOrEmpty(loginRequest.Username) || string.IsNullOrEmpty(loginRequest.Password))
                {
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest; // 400 Bad Request
                    await WriteResponse(context.Response, new { status = "error", message = "Invalid request." });
                    return;
                }

                UserController userController = new UserController();
                int verify = await userController.LogInValidationAsync(loginRequest.Username, loginRequest.Password);

                if (verify == 1)
                {
                    context.Response.StatusCode = (int)HttpStatusCode.OK; // 200 OK
                    await WriteResponse(context.Response, new { status = "success" });
                }
                else
                {
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized; // 401 Unauthorized
                    await WriteResponse(context.Response, new { status = "error", message = "Incorrect Username or Password." });
                }
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError; // 500 Internal Server Error
                await WriteResponse(context.Response, new { status = "error", message = ex.Message });
            }
        }

        private async Task WriteResponse(HttpListenerResponse response, object responseObject)
        {
            string jsonResponse = JsonConvert.SerializeObject(responseObject);
            byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
            await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
            response.OutputStream.Close();
        }

        public class LoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
