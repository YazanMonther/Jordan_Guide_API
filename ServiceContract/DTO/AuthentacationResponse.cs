

namespace ServiceContract.DTO
{
    public class AuthentacationResponse 
    {

        public string? PersonName { get; set; }

        public string? Email { get; set; }

        public string? Token { get; set; }

        public DateTime Expiration { get; set; }



    }
}
