
using RepositoryContract;
using ServiceContract;
using ServiceContract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FAQsServices : IFAQsService
    {
        private readonly IFAQsRepository _FaqsRepository;
          
        public FAQsServices(IFAQsRepository R) 
        { 
           _FaqsRepository = R;
        }


        public async Task<List<FAQsResponse>?> GetAllFAQs()
        {
            List<FAQsResponse>? fAs =  (await _FaqsRepository.GetAllFAQs())?.Select(f =>f.toFAQsResponse()).ToList();


              if (fAs?.Count == 0) throw new ArgumentNullException();

                  return fAs;
        }
    }
}
