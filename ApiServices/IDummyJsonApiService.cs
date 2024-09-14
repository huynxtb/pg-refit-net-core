using Refit;
using RefitSample.Models;
using RefitSample.Models.RequestParam;
using RefitSample.Models.Response;

namespace RefitSample.ApiServices
{
    [Headers(
        "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36",
        "Referer: https://progcoder.com/"
        )]
    public interface IBaseApiService{}

    public interface IDummyJsonApiService : IBaseApiService
    {
        [Get("/users/search")]
        Task<UserResponseListModel> SearchUserAysnc(UserSearchParams searchParams);

        [Get("/users/{userId}")]
        Task<UserModel> GetUserAysnc(string userId);

        [Post("/users/add")]
        Task<UserModel> AddNewUserAysnc([Body] UserModel user, [HeaderCollection] IDictionary<string, string> headers = null);

        [Post("/auth/login")]
        Task<AuthLoginResponseModel> LoginAysnc([Body] AuthLoginModel login);
    }
}
