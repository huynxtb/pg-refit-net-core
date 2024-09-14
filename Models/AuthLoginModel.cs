namespace RefitSample.Models
{
    public class AuthLoginModel
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int ExpiresInMins { get; set; }
    }
}
