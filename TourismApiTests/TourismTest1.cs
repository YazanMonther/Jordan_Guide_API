using Entites;
using Microsoft.IdentityModel.Tokens;
using ServiceContract;
using Services;
using System.Security.Cryptography.X509Certificates;
using EntityFrameworkCoreMock;
using Microsoft.EntityFrameworkCore;
using ServiceContract.DTO;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace TourismApiTests
{
    public class TourismTest1
    {
        private readonly ITourismService _tourismService;
        private readonly ITestOutputHelper _testOutputHelper;
        ApplicationDbContext dbContext;
        public TourismTest1(ITestOutputHelper test)
        {
            _testOutputHelper = test;
            var TourismPlacesIntialData = new List<TourismPlaces>();
           
            DbContextMock<ApplicationDbContext> dbContextMock= new DbContextMock<ApplicationDbContext>(new DbContextOptionsBuilder<ApplicationDbContext>().Options);

             dbContext = dbContextMock.Object;

            dbContextMock.CreateDbSetMock(temp => temp.tourismPlaces);

            _tourismService = new TourismServices(dbContext);
        }


        #region GetTourismPlaces

        [Fact]
        // if the Database data are null it should throw Null Exception
        public async Task  GetTourismPlaces_NullData()
        {
            //Assert
            List<TourismPlaceResponse>? tourismPlaceResponses = await  _tourismService.GetTourismPlaces();
          
            //Assign
            _testOutputHelper?.WriteLine(tourismPlaceResponses?.Count.ToString());
           
            //Act
            await Assert.ThrowsAsync<ArgumentNullException>(async() => await _tourismService.GetTourismPlaces());
        }

        [Fact]
        // if the Database data are null it should throw Null Exception
        public async Task GetTourismPlaces_HasData()
        {
            //Assert
           
            List<TourismPlaceResponse>? tourismPlaceResponses = await _tourismService.GetTourismPlaces();

            //Assign
            _testOutputHelper?.WriteLine(tourismPlaceResponses?.Count.ToString());

            //Act
            await Assert.ThrowsAsync<ArgumentNullException>(async () => await _tourismService.GetTourismPlaces());
        }
        #endregion
    }
}