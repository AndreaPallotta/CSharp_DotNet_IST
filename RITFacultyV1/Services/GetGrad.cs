using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RITFacultyV1.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace RITFacultyV1.Services
{
    public class GetGrad
    {
        public async Task<List<Graduate>> GetGradDegrees() 
        {
            using (var client = new HttpClient()) 
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try 
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync("api/degrees/graduate/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Graduate>>>(data);
                    List<Graduate> graduateList = new List<Graduate>();
                    Graduate graduate = new Graduate();

                    foreach (KeyValuePair<string, List<Graduate>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            graduateList.Add(item);
                        }
                    }

                    return graduateList;
                }

                catch (HttpRequestException hre) 
                {
                    var msg = hre.Message;
                    List<Graduate> gradMajorList = new List<Graduate>();
                    return gradMajorList;
                }

                catch (Exception e) 
                {
                    var msg = e.Message;
                    List<Graduate> gradMajorList = new List<Graduate>();
                    return gradMajorList;
                }
            }
        }
    }
}
