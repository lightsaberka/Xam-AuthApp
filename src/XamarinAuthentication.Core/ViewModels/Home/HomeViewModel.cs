using System.Diagnostics;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace XamarinAuthentication.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
	    public async void Authenticate() 
	    {
			var isFingerprintAvailable = await CrossFingerprint.Current.IsAvailableAsync(false);

		    if (!isFingerprintAvailable) {
				// todo: android - ask to configure if possible 
			    Debug.WriteLine("Error: Biometric authentication is not available or is not configured.");
			    return;
		    }

		    var conf = new AuthenticationRequestConfiguration("Authentication", "We need Your biometric information for authentication.");
		    conf.AllowAlternativeAuthentication = true;

		    var authResult = await CrossFingerprint.Current.AuthenticateAsync(conf);
		    if (authResult.Authenticated) {
				// Success  
				Debug.WriteLine("Success: Authentication succeeded");
		    } else {
				// Fail
			    Debug.WriteLine("Error: Authentication failed");
		    }
	    }
    }
}
