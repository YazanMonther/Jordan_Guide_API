using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites;
namespace RepositoryContract
{
    /// <summary>
    /// Reprensts data access logic for FAQs Enitites
    /// </summary>
    public interface IFAQsRepository
    {
        /// <summary>
        /// Return All FAQs
        /// </summary>
        /// <returns>List of FAQs obj</returns>
        public Task<List<FAQs>?> GetAllFAQs();
    }
}
