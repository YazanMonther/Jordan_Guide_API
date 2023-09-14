using Entites;
using Microsoft.EntityFrameworkCore;
using RepositoryContract;

namespace Repositories
{
    public class TourismPlacesRepository : ITourismPlacesRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TourismPlacesRepository(ApplicationDbContext db)
        {
            _dbContext = db;

        }
        public async Task<List<TourismPlaces>?> GetTourismPlaces()
        {
           return await _dbContext.tourismPlaces.Include("images").ToListAsync();
        }

        public async Task<List<TourismPlaces>?> GetTourismPlacesByCategory(string? category)
        {
           return await _dbContext.tourismPlaces.Include("images").Where(place => place.tourismCategory == category).ToListAsync();
        }


        public async Task<TourismPlaces?> GetTourismPlacesByID(int? id)
        {
            return await _dbContext.tourismPlaces.Include("images").Where(place => place.tourismPlaceId == id).FirstOrDefaultAsync();
        }

        public async Task<List<TourismPlaces>?> GetTourismPlacesByCity(string? city)
        {
            return await _dbContext.tourismPlaces.Include("images").Where(place => place.tourismCity == city).ToListAsync();
        }

        public async Task<List<TourismPlaces>?> GetTourismPlacesByRank(string? rank)
        {
           if(rank  == "ASC")
            {
                return await _dbContext.tourismPlaces.Include("images").OrderBy(place =>Convert.ToDouble( place.tourismRating)).ToListAsync();
            }

            return await _dbContext.tourismPlaces.Include("images").OrderByDescending(place => Convert.ToDouble(place.tourismRating)).ToListAsync();
        }
    }
}