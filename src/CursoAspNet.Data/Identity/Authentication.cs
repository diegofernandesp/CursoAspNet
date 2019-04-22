using CursoAspNet.Domain.Account;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace CursoAspNet.Data.Identity
{
    public class Authentication : IAuthentication
    {
        private readonly SignInManager<ApplicationUser> _SignInManager;
        public Authentication(SignInManager<ApplicationUser> signInManager)
        {
            _SignInManager = signInManager;
        }

        public async Task<bool> Authenticate(string email, string password)
        {
            var result = await _SignInManager.PasswordSignInAsync(email, password, false, lockoutOnFailure: false);
            return result.Succeeded;
        }

    }
}
