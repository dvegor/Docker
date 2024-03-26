using Docker.Contracts.Requests;

namespace Docker.Abstractions
{
    public interface IAuthService
    {
        Task<IResult> Login(UserAuthRequest request);
        Task<IResult> Register(UserAuthRequest request);
    }
}
