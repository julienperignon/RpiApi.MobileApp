using RpiApi.MobileApp.Enums;
using RpiApi.MobileApp.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RpiApi.MobileApp.Services
{
    public class GpioService
    {
        private static string baseApiUrl = "http://192.168.1.106/";
        private static string urlGpioStatus = string.Concat(baseApiUrl, "gpio/", "{0}");

        public async Task<GpioStatus> FetchGpioStatusAsync(GpioPin gpioPin)
        {
            // Create an HTTP web request using the URL:
            var url = string.Format(urlGpioStatus, (int)gpioPin);
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            try
            {
                // Send the request to the server and wait for the response:
                using (WebResponse response = await request.GetResponseAsync())
                {
                    // Get a stream representation of the HTTP web response:
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        // Use this stream to build a JSON document object:
                        string content = await sr.ReadToEndAsync();
                        //await Task.Delay(2000);
                        GpioStatus gpioVm = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<GpioStatus>(content));

                        Debug.WriteLine("Response: {0}", gpioVm.ToString());

                        // Return the JSON document:
                        return gpioVm;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("EXCEPTION" + ex.Message);
            }

            return null;
        }

    }
}
