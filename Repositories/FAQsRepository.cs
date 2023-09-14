using Entites;
using Microsoft.EntityFrameworkCore;
using RepositoryContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FAQsRepository :IFAQsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public FAQsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<FAQs>?> GetAllFAQs()
        {
            return await _dbContext.FAQs.ToListAsync();
        }
    }
}
