namespace ClientApplicationTwo.Models
{
    // Represents the response after SSO token validation, including a new access token and user details.
    public class ValidateSSOResponseModel
    {
        public string? Token { get; set; }
        public UserDetailsModel? UserDetails { get; set; }
    }
}
