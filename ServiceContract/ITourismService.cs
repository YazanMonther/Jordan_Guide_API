
using Entites;
using ServiceContract.DTO;

namespace ServiceContract
{
    public interface ITourismService
    {
        /// <summary>
        /// Return All Tourism Places
        /// </summary>
        /// <returns>List of TourismPlaceResponse obj</returns>
        public  Task<List<TourismPlaceResponse>?> GetTourismPlaces();

        /// <summary>
        ///  Return the TourismPlace with the same id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Tourism place</returns>
        public  Task<TourismPlaceResponse?> GetTourismPlacesByID(int? id);

        /// <summary>
        /// Returns All tourismPlaces with the same categoy fields
        /// </summary>
        /// <param name="category"></param>
        /// <returns>List of Toureism Places </returns>
        public Task<List<TourismPlaceResponse>?> GetTourismPlacesByCategory(string? category);


        /// <summary>
        /// Returns All TourismPlaceResponse with the same City fields
        /// </summary>
        /// <param name="city"></param>
        /// <returns>List of TourismPlaceResponse </returns>
        public Task<List<TourismPlaceResponse>?> GetTourismPlacesByCity(string? city);

        /// <summary>
        /// Returns All TourismPlaceResponse depending on rank fields
        /// </summary>
        /// <param name="rank"></param>
        /// <returns>List of TourismPlaceResponse </returns>
        public Task<List<TourismPlaceResponse>?> GetTourismPlacesByRank(string? rank);

    }
}