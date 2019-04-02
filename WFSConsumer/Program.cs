using System;
using System.Net.Http;

namespace WFSConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var url = "https://services.nationalmap.gov/arcgis/services/WFS/Contours/MapServer/WFSServer?request=getcapabilities&service=wfs";
            HttpClient client = new HttpClient();

          var response=  client.GetAsync(url);
            response.Wait();
          var result= response.Result.Content.ReadAsStringAsync().Result;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
