using Newtonsoft.Json;
using RITFacultyV1.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RITFacultyV1.Services
{
    public class GetAbout
    {
        public async Task<About> GetAllAbout()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync("api/about/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    About about = JsonConvert.DeserializeObject<About>(data);
                    return about;
                }

                catch (HttpRequestException hre)
                {
                    About about = new About();
                    return about;
                }

                catch (Exception e)
                {
                    About about = new About();
                    return about;
                }
            }
        }
    }
}
