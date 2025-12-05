using System.Collections.Generic;
using MyHikingAPI.Models;


namespace MyHikingAPI.Services
{
    public class MountainService
    {
        public List<Mountain> GetAllMountains()
        {
            return JsonReader.GetData<Mountain>("Data/mountains.json");
        }               
    }
}
