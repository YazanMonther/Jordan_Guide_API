using Entites;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using ServiceContract;
using ServiceContract.DTO;
using RepositoryContract;

namespace Services
{
    public class TourismServices :ITourismService
    {
        private readonly ITourismPlacesRepository _TourismPlacesRepository;


        public TourismServices(ITourismPlacesRepository tourism)
        {
            _TourismPlacesRepository = tourism;
        }



        public  async Task<List<TourismPlaceResponse>?> GetTourismPlaces()
        {
            List<TourismPlaceResponse>? tourismPlaceResponsesList = ( await _TourismPlacesRepository.GetTourismPlaces())?.Select(tourim => tourim.TotourismPlaceResponse()).ToList();

            if (tourismPlaceResponsesList?.Count ==0) throw new ArgumentNullException();
           
            return tourismPlaceResponsesList;
        }

       public async Task<TourismPlaceResponse?> GetTourismPlacesByID(int? id)
        {
            if (id == null) throw new ArgumentNullException("Null Id is provided");

            TourismPlaces? tourismPlace = await _TourismPlacesRepository.GetTourismPlacesByID(id);

            if (tourismPlace == null) throw new ArgumentNullException("There is no Tourism Place with this Id");
         
            TourismPlaceResponse tourismPlaceResponse = tourismPlace.TotourismPlaceResponse();

            if (tourismPlaceResponse == null) throw new ArgumentNullException(nameof(TourismPlaces));

            return tourismPlaceResponse;
        }

        public async Task<List<TourismPlaceResponse>?> GetTourismPlacesByCategory(string? category)
        {
            if (category == null) throw new ArgumentNullException("The provied categoty is null !");

            List<TourismPlaces>? tourismPlaces = await _TourismPlacesRepository.GetTourismPlacesByCategory(category);

           if (tourismPlaces == null) throw new ArgumentNullException("There are No Data with mathces this category ");
        
            return  tourismPlaces.Select(tourismPlace => tourismPlace.TotourismPlaceResponse()).ToList();
    
        }

        public async Task<List<TourismPlaceResponse>?> GetTourismPlacesByCity(string? city)
        {
            if (city == null)
                throw new ArgumentNullException("no parameter provided");
            List<TourismPlaces>? tourismPlace = await _TourismPlacesRepository.GetTourismPlacesByCity(city);
            if (tourismPlace == null)
                throw new ArgumentNullException("No result");

            return tourismPlace.Select(place => place.TotourismPlaceResponse()).ToList();
        }

        public async Task<List<TourismPlaceResponse>?> GetTourismPlacesByRank(string? rank)
        {
            if (rank == null)
                throw new ArgumentNullException();

            if (rank != "ASC" && rank != "DEC")
            {
                throw new ArgumentException("Wrong parameter");
            }

            List<TourismPlaces>? tourismPlaces = await _TourismPlacesRepository.GetTourismPlacesByRank(rank);

            if (tourismPlaces == null)
                throw new ArgumentNullException("No data");

            return tourismPlaces.Select(place => place.TotourismPlaceResponse()).ToList();
        }
    }
}
