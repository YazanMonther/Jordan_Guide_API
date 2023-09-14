using Entites.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Win32;
using RepositoryContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManger;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> sign, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _signInManger = sign;
            _roleManager = roleManager;
        }


        public async Task<bool> IsEmailAllreadyRegister(string? email)
        {
            if(email == null)
            {
                throw new ArgumentNullException("Email shouldnt be null");
            }

            ApplicationUser? user = await _userManager.FindByEmailAsync(email);

            if(user == null)
            {
                return true;
            }
            return false;
        }

        public async Task<ApplicationUser?> LoginUser(string? Email ,string? pass)
        {

            if(Email ==null || pass == null)
            {
                throw new ArgumentNullException("Email or password cant be null");
            }

            var result = await _signInManger.PasswordSignInAsync(Email, pass, isPersistent: false,lockoutOnFailure:false); ;

            if (result.Succeeded)
            {
                ApplicationUser? user =await _userManager.FindByEmailAsync(Email);

                if(user == null)
                {
                    return null;
                }
                return user;
            }

            return null;
            
        }

        public async Task<ApplicationUser?> LogOut()
        {

            await _signInManger.SignOutAsync();

            return null;
        }

        public async Task<ApplicationUser?> RegisgerUser( string? Email, string? PhoneNumber ,string? PersonName,DateTime? Birthday,string? pass)
        {

            if(Email ==null ||PhoneNumber == null|| PersonName == null || Birthday == null || pass == null)
            {
                throw new ArgumentNullException("Registeration data cant be null");
            }
            ApplicationUser user = new ApplicationUser()
            {
                Email = Email,
                PhoneNumber = PhoneNumber,
                PersonName = PersonName,
                UserName = Email,
                BirthDay = Birthday,


            };
            IdentityResult result = await _userManager.CreateAsync(user, pass);

            if (result.Succeeded)
            {
                await _signInManger.SignInAsync(user, isPersistent: false);

                return user;
            }
            else
            {
                string error = string.Join(" , ", result.Errors.Select(e => e.Description));

                return null;
            }

           
        }
    }
}
