using System.Collections.Generic;
using System.IO;
using MyHikingAPI.Models;
using Newtonsoft.Json;

namespace MyHikingAPI.Services
{
    public static class JsonReader
    {
        public static List<T> GetData<T>(string filename)
        {
           var JsonString = File.ReadAllText(filename); 
           return JsonConvert.DeserializeObject<List<T>>(JsonString);

        }
    }
}
