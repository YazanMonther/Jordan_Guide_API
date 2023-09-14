using Azure.Core;
using Entites;
using Microsoft.EntityFrameworkCore;
using RepositryContract;
using ServiceContract;
using ServiceContract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TrendingEventsServices : ITrendingEventsServices
    {
        private readonly ITrendingEventsRepository trendingEventsRepository;
        public TrendingEventsServices(ITrendingEventsRepository r) 
        {
            trendingEventsRepository = r;
        }



        public async Task<List<TrendingEventsResponse>?> GetTrendingEvents()
        {
            List<TrendingEventsResponse>? trendingEvents = (await trendingEventsRepository.GetTrendingEvents())?.Select(e => e.TrendingEventsResponse()).ToList();

            if (trendingEvents?.Count == 0) throw new ArgumentNullException();

            return trendingEvents;
        }

        public async Task<List<TrendingEventsResponse>?> GetTrendingEventsByCityName(string? city)
        {
            if (city == null)
                throw new ArgumentNullException("Provide a city name ");

            List<TrendingEventsResponse>? trendingEventsResponses = (await trendingEventsRepository.GetTrendingEventsByCityName(city))?.Select(e => e.TrendingEventsResponse()).ToList();

            if (trendingEventsResponses?.Count == 0)
                throw new ArgumentException("No Events with this city name");

            return trendingEventsResponses;                    
        }
    }
}
