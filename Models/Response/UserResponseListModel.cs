namespace RefitSample.Models.Response
{
    public class UserResponseListModel
    {
        public List<UserModel> Users { get; set; } = new();
        public int Total { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }
}
