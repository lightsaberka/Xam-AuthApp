using System.Diagnostics;
using System.Threading.Tasks;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace XamarinAuthentication.Core.Services.Authentication
{
	public class AuthService: IAuthService
	{
		public async Task<bool> Authenticate()
		{
			var isAuthenticationAvailable = await CrossFingerprint.Current.IsAvailableAsync(true);

			if (!isAuthenticationAvailable) {

				// todo: android - ask to configure if possible

				Debug.WriteLine("Error: Biometric authentication is not available or is not configured.");
				return false;
			}

			// configure authentication prompt
			var conf = new AuthenticationRequestConfiguration("Authentication", "We need Your biometric information for authentication.");

			// allow PIN/pattern authentication if biometric is unsuccesfull
			conf.AllowAlternativeAuthentication = true;

			var authResult = await CrossFingerprint.Current.AuthenticateAsync(conf);

			if (authResult.Authenticated) {

				Debug.WriteLine("Success: Authentication succeeded");
				return true;

			} else {
				Debug.WriteLine("Error: Authentication failed");
				return false;
			}
		}
	}
}