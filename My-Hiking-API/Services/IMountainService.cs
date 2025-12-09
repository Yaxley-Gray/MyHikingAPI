using System;
using System.Collections.Generic;
using MyHikingAPI.Models;

namespace MyHikingAPI.Services;

public interface IMountainService
{
    List<Mountain> GetAllMountains();

}
