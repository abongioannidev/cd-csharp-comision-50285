using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Provider
{
    public abstract class AbstractProvider
    {

        private readonly HttpClient httpClient;
        protected readonly string host;
        protected AbstractProvider()
        {
            httpClient = new HttpClient();
            this.host = @"https://localhost:5001/api";
        }

        protected virtual string GetString(string recurso)
        {
            string url = $"{this.host}/{recurso}";
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);

            try
            {
                HttpResponseMessage? response = httpClient.Send(httpRequestMessage);
                if (!response.IsSuccessStatusCode)
                {

                    throw new Exception($"La respuesta no fue exitosa, se obtuvo un estado {response.StatusCode}");
                }
                Task<string>? resultado = response.Content.ReadAsStringAsync();
                resultado.Wait();
                return resultado.Result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar la solicitud get de string", ex);
            }

        }

        protected virtual T GetJson<T>(string recurso) where T : class
        {
            string url = $"{this.host}/{recurso}";
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);

            try
            {
                HttpResponseMessage? response = httpClient.Send(httpRequestMessage);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"La respuesta no fue exitosa, se obtuvo un estado {response.StatusCode}");
                }
                Task<T?> resultado = response.Content.ReadFromJsonAsync<T>();
                resultado.Wait();
                return resultado.Result!;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar la solicitud get de json", ex);
            }


        }

        private ApiResponse PostAndPutJson<T>(string recurso, T data, HttpMethod metodo ) where T : class
        {
            string url = $"{this.host}/{recurso}";
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(metodo, url);


            string dataSerializada = JsonSerializer.Serialize(data);
            httpRequestMessage.Content = new StringContent(dataSerializada, Encoding.UTF8, "application/json");

            try
            {

                HttpResponseMessage? response = httpClient.Send(httpRequestMessage);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"La respuesta no fue exitosa, se obtuvo un estado {response.StatusCode}");
                }
                Task<ApiResponse?> resultado = response.Content.ReadFromJsonAsync<ApiResponse>();
                resultado.Wait();
                return resultado.Result!;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al procesar la solicitud {metodo} del json", ex);
            }
        }


        protected virtual ApiResponse PutJson<T>(string recurso, T data) where T : class
        {
            return this.PostAndPutJson(recurso,data, HttpMethod.Put);
        }

        protected virtual ApiResponse PostJson<T>(string recurso, T data) where T : class
        {
            return this.PostAndPutJson(recurso, data, HttpMethod.Post);
        }

        protected virtual ApiResponse Delete(string recurso)
        {
            string url = $"{this.host}/{recurso}";
            HttpMethod httpMethod = HttpMethod.Delete;
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(httpMethod, url);
            try
            {

                HttpResponseMessage? response = httpClient.Send(httpRequestMessage);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"La respuesta no fue exitosa, se obtuvo un estado {response.StatusCode}");
                }
                Task<ApiResponse?> resultado = response.Content.ReadFromJsonAsync<ApiResponse>();
                resultado.Wait();
                return resultado.Result!;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al procesar la solicitud {httpMethod}", ex);
            }

        }
    }
}
