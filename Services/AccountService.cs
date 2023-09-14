using Entites.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RepositoryContract;
using ServiceContract;
using ServiceContract.DTO;


namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IJwtService _jwtService;

        public AccountService(IAccountRepository accountRepository, IJwtService jwtService)
        {
            this.accountRepository = accountRepository;
            this._jwtService = jwtService;
        }

        public async Task<bool> IsEmailAllreadyRegister(string? email)
        {
            if(email == null)
            {
                throw new ArgumentNullException("Email cant be null");
            }
            return await accountRepository.IsEmailAllreadyRegister(email);
        }

        public async Task<AuthentacationResponse?> LoginUser(LoginAddRequest? LoginReq)
        {
            if(LoginReq.Email == null || LoginReq.Password ==null)
            {
                throw new ArgumentNullException("Email or Password is null");
            }
            ApplicationUser? applicationUser = await accountRepository.LoginUser(LoginReq.Email, LoginReq.Password);

            if(applicationUser == null)
            {
                throw new ArgumentNullException("No User with this data");
            }


            var AuthResponse = _jwtService.CreateJwtToken(applicationUser);
 
            return AuthResponse;
        }

        public void LogOut()
        {
            accountRepository.LogOut();
          
        }

        public async Task<AuthentacationResponse?> RegisgerUser(ResgisterAddRequest? register)
        {

            //if(register.Email ==null || register.PhoneNumer ==null || register.PersonName==null || register.BirthDay ==null || register.Password)
            //{
            //    throw new ArgumentNullException("Registeration data cant be null");
            //}


            var applicationReg =  await accountRepository.RegisgerUser(register?.Email, register?.PhoneNumer, register?.PersonName, register?.BirthDay, register?.Password);

            if(applicationReg == null)
            {
                throw new ArgumentNullException("Register process returns null value");
            }

            var authResponse = _jwtService.CreateJwtToken(applicationReg);

            return authResponse;

        }
    }
}
