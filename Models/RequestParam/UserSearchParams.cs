using Refit;

namespace RefitSample.Models.RequestParam
{
    public class UserSearchParams
    {
        [AliasAs("q")]
        public string SearchText { get; set; } = string.Empty;
        [AliasAs("limit")]
        public int Limit { get; set; }
        [AliasAs("skip")]
        public int Skip { get; set; }
    }
}
