using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using System.Security.Claims;

namespace Spotify.Spotify
{
    public class SpotifyOptions : OAuthOptions
    {
        public SpotifyOptions()
        {
            CallbackPath = "/signin-spotify";
            AuthorizationEndpoint = SpotifyDefaults.AuthorizationEndpoint;
            TokenEndpoint = SpotifyDefaults.TokenEndpoint;
            UserInformationEndpoint = SpotifyDefaults.UserInformationEndpoint;

            Scope.Add("user-read-email");
            Scope.Add("user-read-private");

            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "display_name");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "email");
            ClaimActions.MapJsonKey(ClaimTypes.Country, "country");


        }

        public string? AccessType { get; set; }
    }
}
