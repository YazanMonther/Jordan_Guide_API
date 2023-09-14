using Entites;
using ServiceContract.DTO;

namespace ServiceContract
{
    public interface ITrendingEventsServices
    {
        /// <summary>
        /// Return All Trending Events
        /// </summary>
        /// <returns>List of TrendingEventsResponse obj</returns>
        public Task<List<TrendingEventsResponse>?> GetTrendingEvents();



        /// <summary>
        /// Returns All TrendingEvents with the same city name 
        /// </summary>
        /// <param name="city"></param>
        /// <returns>List of TrendingEventsResponse </returns>
        public Task<List<TrendingEventsResponse>?> GetTrendingEventsByCityName(string? city);



    }
}
