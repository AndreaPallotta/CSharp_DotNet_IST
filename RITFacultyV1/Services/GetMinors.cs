using Newtonsoft.Json;
using RITFacultyV1.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RITFacultyV1.Services
{
    public class GetMinors
    {
        public async Task<List<Minors>> GetMinorsDegree()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync("api/minors/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Minors>>>(data);
                    List<Minors> minorsList = new List<Minors>();
                    Minors minors = new Minors();

                    foreach (KeyValuePair<string, List<Minors>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            minorsList.Add(item);
                            Console.WriteLine(item);
                        }
                    }

                    return minorsList;
                }

                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Minors> minorsList = new List<Minors>();
                    return minorsList;
                }

                catch (Exception e)
                {
                    var msg = e.Message;
                    List<Minors> minorsList = new List<Minors>();
                    return minorsList;
                }
            }
        }
    }
}
