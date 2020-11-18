using Newtonsoft.Json;
using RITFacultyV1.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RITFacultyV1.Services
{
    public class GetTables
    {
        public async Task<Tables> GetCoop()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync("api/employment/coopTable/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    Tables coop = JsonConvert.DeserializeObject<Tables>(data);
                    return coop;
                }

                catch (HttpRequestException hre)
                {
                    Tables coop = new Tables();
                    return coop;
                }

                catch (Exception e)
                {
                    Tables coop = new Tables();
                    return coop;
                }
            }
        }

        public async Task<Tables> GetEmployer()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync("api/employment/employmentTable/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    Tables emp = JsonConvert.DeserializeObject<Tables>(data);
                    return emp;
                }

                catch (HttpRequestException hre)
                {
                    Tables emp = new Tables();
                    return emp;
                }

                catch (Exception e)
                {
                    Tables emp = new Tables();
                    return emp;
                }
            }
        }
    }
}
