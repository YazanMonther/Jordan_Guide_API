using Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContract
{
    public  interface IAccountRepository
    {

        /// <summary>
        /// Register The User to the DB
        /// </summary>
        /// <param name="user"> ApplicationUser Obj</param>
        /// <returns> ApplicationUser Obj</returns>
        public Task<ApplicationUser?> RegisgerUser(string? Email, string? PhoneNumber, string? PersonName, DateTime? Birthday, string? pass);

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

        public Task<ApplicationUser?> LoginUser(string? Email ,string? pass);

        /// <summary>
        /// Sign the user out
        /// </summary>
        /// <returns></returns>

        public Task<ApplicationUser?> LogOut(); 


    }
}
