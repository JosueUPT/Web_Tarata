using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace AppTurismoTarata.Middleware
{
    public class RequestLoggingMiddleware : HttpTaskAsyncHandler
    {
        public override async Task ProcessRequestAsync(HttpContext context)
        {
            var browser = context.Request.UserAgent;
            var ip = context.Request.UserHostAddress;
            var url = context.Request.Url?.PathAndQuery;
            var timestamp = System.DateTime.UtcNow;
            //var country = await ObtenerPaisPorIP(ip);

            // Aquí puedes guardar estos datos en una base de datos o archivo de logs
            //System.Diagnostics.Debug.WriteLine($"Visita: Pais={country},IP={ip}, Browser={browser}, URL={url}, Time={timestamp}");
            System.Diagnostics.Debug.WriteLine($"Visita: IP={ip}, Browser={browser}, URL={url}, Time={timestamp}");

            await Task.CompletedTask;
        }

        public override bool IsReusable => false;

        // Método para obtener el país utilizando la API de ipapi.co
        //private static async Task<string> ObtenerPaisPorIP(string ip)
        //{
        //    try
        //    {
        //        using (var httpClient = new HttpClient())
        //        {
        //            // Hacer la solicitud GET a la API
        //            var response = await httpClient.GetStringAsync($"https://ipapi.co/{ip}/country_name/");
        //            return response.Trim(); // Devolver el nombre del país
        //        }
        //    }
        //    catch
        //    {
        //        return "Desconocido";
        //    }
        //}
    }

}