using FluentAssertions;
using MyHikingAPI.Services;

namespace MyHikingAPI.Tests
{
    public class ServicesTest
    {
        [Fact]
        public void GetAllMountains_CheckIfReturnsPopulatedList()
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
            Assert.NotNull(mountains); // checks if list is not null
            Assert.NotEmpty(mountains); // checks if list is not empty 
            mountains.Should().NotBeNullOrEmpty();


        }
    
        }
    }

