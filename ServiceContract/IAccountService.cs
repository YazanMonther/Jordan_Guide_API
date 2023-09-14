
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceContract.DTO;
namespace ServiceContract
{
    public interface IAccountService
    {

        /// <summary>
        /// Register The User to the DB
        /// </summary>
        /// <param name="user"> ApplicationUser Obj</param>
        /// <returns> ApplicationUser Obj</returns>
        public Task<AuthentacationResponse?> RegisgerUser(ResgisterAddRequest? resgister);

        /// <summary>
        /// Checking if email is already register 
        /// </summary>
        /// <param name="email"> string email address</param>
        /// <returns></returns>
        public Task<bool> IsEmailAllreadyRegister(string? email);

        /// <summary>
        /// LogIn the registered user so he can use the system
        /// </summary>
        /// <param name="user"> Application User obj</param>
        /// <returns>Application User obj</returns>

        public Task<AuthentacationResponse?> LoginUser(LoginAddRequest? Login);

        /// <summary>
        /// Sign the user out
        /// </summary>
        /// <returns></returns>

        public void LogOut();
    }
}
