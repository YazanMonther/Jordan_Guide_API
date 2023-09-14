using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContract.DTO
{
    public class FAQsResponse
    {
        public string? Question { get; set; }

        
        public string? Answer { get; set; }
    }

    public static class FAQsEx
    {
        public static FAQsResponse toFAQsResponse( this FAQs? qs)
        {
            return new FAQsResponse()
            {
                Question = qs?.Question,
                Answer = qs?.Answer
            };

        }
    }
}
