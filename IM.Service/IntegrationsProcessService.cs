using IM.Domain.Interface.Service;
using IM.Domain.Model;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;

namespace IM.Service
{
    public class IntegrationsProcessService : IIntegrationsProcessService
    {
        public Process GetLastProcess()
        {
            return GetProcessResult();
        }

        public void UpdateProcess()
        {
            var process = GetProcessList();

            process.UrlsServices.ForEach(item =>
            {
                try
                {
                    item.Status = "OK";
                    HttpClient client = new HttpClient();

                    var html = client.GetStringAsync(item.Url).Result;

                    if (!string.IsNullOrEmpty(item.SeekToOk))
                        item.Status = html.Contains(item.SeekToOk) ? "OK" : "WRN";

                    if (item.Status == "WRN")
                        item.Error = "Request OK, but the keyword was not found.";
                }
                catch(Exception ex)
                {
                    item.Error = ex.InnerException.ToString();
                    item.Status = "ERR";
                }
            });

            SaveProcessResult(process);
        }

        private void SaveProcessResult(Process process)
        {
            var path = $"{Directory.GetCurrentDirectory()}\\endpoints-config-result.json";
           
            using (var stream = new StreamWriter(path))
            {
                var json = JsonConvert.SerializeObject(process);
                stream.WriteLine(json);
            }
        }

        private Process GetProcessResult()
        {
            var path = $"{Directory.GetCurrentDirectory()}\\endpoints-config-result.json";
            
            using (var stream = new StreamReader(path))
            {
                var json = stream.ReadToEnd();

                if (string.IsNullOrEmpty(json))
                    return null;

                return JsonConvert.DeserializeObject<Process>(json);
            }
        }

        private Process GetProcessList()
        {
            using (var stream = new StreamReader($"{Directory.GetCurrentDirectory()}\\endpoints-config.json"))
            {
                var json = stream.ReadToEnd();
                return JsonConvert.DeserializeObject<Process>(json);
            }
        }
    }
}
