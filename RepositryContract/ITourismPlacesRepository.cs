using Entites;
namespace RepositoryContract
{
    /// <summary>
    /// Repprensts Data acess logic for managing TourismPlaces Entity
    /// </summary>
    public interface ITourismPlacesRepository
    {
        /// <summary>
        /// Return All Tourism Places
        /// </summary>
        /// <returns>List of TourismPlace obj</returns>
        public Task<List<TourismPlaces>?> GetTourismPlaces();

        /// <summary>
        ///  Return the TourismPlace obj with the same id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>TourismPlace</returns>
        public Task<TourismPlaces?> GetTourismPlacesByID(int? id);

        /// <summary>
        /// Returns All tourismPlaces with the same categoy fields
        /// </summary>
        /// <param name="category"></param>
        /// <returns>List of ToureismPlaces </returns>
        public Task<List<TourismPlaces>?> GetTourismPlacesByCategory(string? category);

        /// <summary>
        /// Returns All tourismPlaces with the same City fields
        /// </summary>
        /// <param name="city"></param>
        /// <returns>List of ToureismPlaces </returns>
        public Task<List<TourismPlaces>?> GetTourismPlacesByCity(string? city);

        /// <summary>
        /// Returns All tourismPlaces depending on rank fields
        /// </summary>
        /// <param name="rank"></param>
        /// <returns>List of ToureismPlaces </returns>
        public Task<List<TourismPlaces>?> GetTourismPlacesByRank(string? rank);



    }
}