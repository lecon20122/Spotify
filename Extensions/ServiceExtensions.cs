using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Spotify.Spotify;

namespace Spotify.Extensions
{
    public static class ServiceExtensions
    {
        public static AuthenticationBuilder AddSpotify(this AuthenticationBuilder builder, Action<OAuthOptions> configureOptions)
        {
            return builder
                .AddOAuth(SpotifyDefaults.AuthenticationScheme, SpotifyDefaults.DisplayName, configureOptions);
        }

    }
}
