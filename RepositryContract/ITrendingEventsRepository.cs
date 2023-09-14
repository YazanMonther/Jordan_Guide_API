using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites;
namespace RepositryContract
{

    /// <summary>
    /// Represnt data access logic for TrendingEvients Enitites
    /// </summary>
    public interface ITrendingEventsRepository
    {
        /// <summary>
        /// Return All Trending Events
        /// </summary>
        /// <returns>List of TrendingEvents obj</returns>
        public Task<List<TrendingEvents>?> GetTrendingEvents();


        /// <summary>
        /// Returns All TrendingEvents with the same city name 
        /// </summary>
        /// <param name="city"></param>
        /// <returns>List of TrendingEvents </returns>
        public Task<List<TrendingEvents>?> GetTrendingEventsByCityName(string? city);

    }
}
