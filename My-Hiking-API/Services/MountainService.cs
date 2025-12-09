using System.Collections.Generic;
using MyHikingAPI.Services;
using MyHikingAPI.Models;


namespace MyHikingAPI.Services
{
    public class MountainService :  IMountainService
    {
        public List<Mountain> GetAllMountains()
        {
            return JsonReader.GetData<Mountain>("Data/mountains.json");
        }               
    }
}
