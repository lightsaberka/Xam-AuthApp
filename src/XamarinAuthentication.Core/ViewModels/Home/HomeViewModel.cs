using Acr.UserDialogs;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinAuthentication.Core.Services.Authentication;
using XamarinAuthentication.Core.ViewModels.Tabs;

namespace XamarinAuthentication.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
	    private readonly IMvxNavigationService _navigationService;
	    private readonly IAuthService _authService;

		private IMvxAsyncCommand _authenticateCommand;

		public HomeViewModel(IMvxNavigationService navigationService, IAuthService authService)
		{
			this._navigationService = navigationService;
			this._authService = authService;
		}

		/// <summary>
		/// Authenticate user and go inside the application.
		/// </summary>
		public IMvxAsyncCommand AuthenticateCommand
	    {
		    get {
			    if (this._authenticateCommand == null) {
				    this._authenticateCommand = new MvxAsyncCommand(async () =>
				    {
					    var wasAuthenticated = false;

					    using (UserDialogs.Instance.Loading()) {
						    wasAuthenticated = await this._authService.Authenticate();
					    }

					    if (wasAuthenticated) {
						    await this._navigationService.Navigate<TabsRootViewModel>();
					    }
				    });
			    }
			    return this._authenticateCommand;
		    }
	    }
    }
}
