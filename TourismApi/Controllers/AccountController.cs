using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Entites.Identity;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using ServiceContract.DTO;
using ServiceContract;

namespace TourismApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

   

        public AccountController(IAccountService account)
        {
            _accountService = account;
        }


        /// <summary>
        /// Post endpoint for Register 
        /// </summary>
        /// <param name="register">RegisterDto Obj</param>
        /// <returns>ApplicationUser to store in Db</returns>
        [HttpPost("register")]
        public async Task<ActionResult<AuthentacationResponse>> PostRegister(ResgisterAddRequest? register)
        {
            //Validation

            
            if(ModelState.IsValid == false)
            {
            string error =  string.Join(" , " ,ModelState.Values.SelectMany(v => v.Errors).Select(v => v.ErrorMessage));

                return Problem(error);
            }

            bool check = await _accountService.IsEmailAllreadyRegister(register.Email);

            if(check == false)
            {
                return Problem("Email is allready Register");
            }


            AuthentacationResponse? response = await _accountService.RegisgerUser(register);

            if(response == null)
            {
                return Problem("Cant Register these data");
            }

            return response;
        }

        

        [HttpPost("login")]
        public async Task<ActionResult<AuthentacationResponse>> PostLogin(LoginAddRequest? login)
        {
            //Validation

            if (ModelState.IsValid == false)
            {
                string error = string.Join(" , ", ModelState.Values.SelectMany(v => v.Errors).Select(v => v.ErrorMessage));

                return Problem(error);
            }

            AuthentacationResponse? response = await _accountService.LoginUser(login);

            if(response == null)
            {
                return Problem("Invalid email or passowrd ");
            }

            return response;
            
        }


        [HttpGet("LogOut")]
         
         public async  Task<IActionResult> GetLogOut()
         {
             _accountService.LogOut();
            return NoContent();
         }

        }
}

