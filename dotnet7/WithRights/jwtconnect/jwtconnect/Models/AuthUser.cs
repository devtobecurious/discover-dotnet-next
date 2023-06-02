namespace jwtconnect.Models
{
    public class AuthUser
    {
        public string? Login { get; set; }
        public string? Password { get; set; }

        public string? Token { get; set; }
    }
}
