using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Demo_Test.Models;
using Newtonsoft.Json;

namespace Demo_Test.Apis
{
    public class GetDataApi
    {
        private string link = "https://www.metaweather.com/api/location/862592/";

        public async Task<ListData<Data_Wheather>> Get_Data_WheatherAsync()
        {
            ListData<Data_Wheather> result = new ListData<Data_Wheather>();
            try
            {
                using (var client = new HttpClient())
                {
                    string linkapi = link;
                    
                    var tam = await client.GetStringAsync(linkapi);
                    result = JsonConvert.DeserializeObject<ListData<Data_Wheather>>(tam);
                }
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
