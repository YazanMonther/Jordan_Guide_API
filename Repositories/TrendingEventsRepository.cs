using Entites;
using Microsoft.EntityFrameworkCore;
using RepositryContract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TrendingEventsRepository : ITrendingEventsRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public TrendingEventsRepository(ApplicationDbContext db)
        {
            _dbContext = db;

        }
        public async Task<List<TrendingEvents>?> GetTrendingEvents()
        {
            return await _dbContext.trendingEvents.Include("Images").ToListAsync();
        }

        public async Task<List<TrendingEvents>?> GetTrendingEventsByCityName(string? city)
        {
            return await _dbContext.trendingEvents.Include("Images").Where(t => t.eventCity ==city).ToListAsync();
        }
    }
}
