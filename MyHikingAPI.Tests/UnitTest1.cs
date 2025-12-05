using FluentAssertions;
using MyHikingAPI.Services;

namespace MyHikingAPI.Tests
{
    public class ServicesTest
    {
        [Fact]
        public void GetAllMountains_CheckIfReturnsPopulatedListOfMountains()
        {
            //Arrange 
            MountainService mountainService = new MountainService(); 
            
            // Creates a new instance of mountainService using its default constructor
            // This object will be used to call the service methods

            //Act 
            var mountains = mountainService.GetAllMountains(); 
            
            // Calls the GetAllMountains() method on the mountainService instance.
            // The method returns a List<Mountain>, which is stored in the variable 'mountains'.
            
            //Assert 
            mountains.Should().NotBeNullOrEmpty(); // checks if list is not null or empty 


        }
    
        }
    }

