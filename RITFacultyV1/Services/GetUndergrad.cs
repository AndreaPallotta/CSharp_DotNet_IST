using Newtonsoft.Json;
using RITFacultyV1.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RITFacultyV1.Services
{
    public class GetUndergrad
    {
        public async Task<List<Undergraduate>> GetDegrees()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync("api/degrees/undergraduate/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Undergraduate>>>(data);
                    List<Undergraduate> undergradList = new List<Undergraduate>();
                    Undergraduate undergraduate = new Undergraduate();

                    foreach (KeyValuePair<string, List<Undergraduate>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            undergradList.Add(item);
                        }
                    }

                    return undergradList;
                }

                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Undergraduate> undergradList = new List<Undergraduate>();
                    return undergradList;
                }

                catch (Exception e)
                {
                    var msg = e.Message;
                    List<Undergraduate> undergradList = new List<Undergraduate>();
                    return undergradList;
                }
            }
        }
    }
}
