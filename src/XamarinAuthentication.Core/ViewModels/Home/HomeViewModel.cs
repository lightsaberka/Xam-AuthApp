using System.Diagnostics;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using XamarinAuthentication.Core.ViewModels.Tabs;

namespace XamarinAuthentication.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
	    private readonly IMvxNavigationService _navigationService;
		private IMvxAsyncCommand _authenticateCommand;

		public HomeViewModel(IMvxNavigationService navigationService)
		{
			this._navigationService = navigationService;
		}

		/// <summary>
		/// Authenticate user.
		/// </summary>
		public IMvxAsyncCommand AuthenticateCommand
	    {
		    get {
			    if (this._authenticateCommand == null) {
				    this._authenticateCommand = new MvxAsyncCommand(async () => {
					    await this.Authenticate();
				    });
			    }
			    return this._authenticateCommand;
		    }
	    }

		/// <summary>
		/// Authenticate user using his Biometric information or PIN/pattern.
		/// If succesfull, go inside the application.
		/// </summary>
		/// <returns></returns>
		private async Task Authenticate() 
	    {
			var isFingerprintAvailable = await CrossFingerprint.Current.IsAvailableAsync(true);

		    if (!isFingerprintAvailable) {

				// todo: android - ask to configure if possible 
			    Debug.WriteLine("Error: Biometric authentication is not available or is not configured.");
			    return;
		    }

			// configure authentication prompt
		    var conf = new AuthenticationRequestConfiguration("Authentication", "We need Your biometric information for authentication.");
		    
		    // allow PIN/pattern authentication if biometric is unsuccesfull
		    conf.AllowAlternativeAuthentication = true;

		    var authResult = await CrossFingerprint.Current.AuthenticateAsync(conf);

		    if (authResult.Authenticated) {
			    Debug.WriteLine("Success: Authentication succeeded");

				// go inside the application (Dashboard page)
				await this._navigationService.Navigate<TabsRootViewModel>();

			} else {
			    Debug.WriteLine("Error: Authentication failed");
		    }
	    }
    }
}
