using System.Threading.Tasks;

namespace CursoAspNet.Domain.Account
{
    public interface IAuthentication
    {
        Task<bool> Authenticate(string email, string password);
    }
}
