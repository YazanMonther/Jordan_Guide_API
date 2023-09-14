using ServiceContract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContract
{
    public interface IFAQsService
    {

        /// <summary>
        /// Return All FAQs
        /// </summary>
        /// <returns>List of FAQsResponse obj</returns>
        public Task<List<FAQsResponse>?> GetAllFAQs();

    }
}
