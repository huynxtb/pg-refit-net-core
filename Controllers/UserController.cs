using Microsoft.AspNetCore.Mvc;
using RefitSample.ApiServices;
using RefitSample.Models;
using RefitSample.Models.RequestParam;

namespace RefitSample.Controllers
{
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IDummyJsonApiService _dummyJsonApiService;

        public UserController(IDummyJsonApiService dummyJsonApiService)
        { 
            _dummyJsonApiService = dummyJsonApiService; 
        }

        [Route("search")]
        [HttpGet]
        public async Task<ActionResult> Search(string searchText, int limit = 5, int skip = 0) 
        {
            var data = await _dummyJsonApiService.SearchUserAysnc(new UserSearchParams()
            {
                SearchText = searchText,
                Limit = limit,
                Skip = skip
            });

            return new JsonResult(data);
        }

        [Route("detail")]
        [HttpGet]
        public async Task<ActionResult> UserDetail(string userId)
        {
            var data = await _dummyJsonApiService.GetUserAysnc(userId);

            return new JsonResult(data);
        }

        [Route("add")]
        [HttpPost]
        public async Task<ActionResult> Add(UserModel request)
        {
            var loginResponse = await _dummyJsonApiService.LoginAysnc(new AuthLoginModel()
            {
                ExpiresInMins = 60,
                Username = "emilys",
                Password = "emilyspass"
            });

            var headers = new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {loginResponse.Token}" }
            };

            var data = await _dummyJsonApiService.AddNewUserAysnc(request, headers);

            return new JsonResult(data);
        }
    }
}
