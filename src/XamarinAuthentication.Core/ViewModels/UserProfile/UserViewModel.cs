using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Xamarin.Essentials;
using XamarinAuthentication.Core.Models;
using XamarinAuthentication.Core.Services.DataService;

namespace XamarinAuthentication.Core.ViewModels.UserProfile
{
	public class UserViewModel: MvxNavigationViewModel
	{
		private readonly IExampleDataService _exampleDataService;

		public User CurrentUser { get; set; }

		public string LoremIpsum { get; set; }

		public UserViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IExampleDataService exampleDataService) 
			: base(logProvider, navigationService)
		{
			this._exampleDataService = exampleDataService;
		}

		public override Task Initialize()
		{
			this.CurrentUser = this._exampleDataService.GetUser();
			this.LoremIpsum = this._exampleDataService.GetLoremIpsum();

			return base.Initialize();
		}

		/// <summary>
		/// Open default e-mail application to send e-mail to provided e-mail address.
		/// note: On iOS this works only on real device, not simulator.
		/// </summary>
		public IMvxCommand OpenEmailCommand => new MvxCommand<string>(async (email) => await Launcher.OpenAsync($"mailto:{email}"));

		/// <summary>
		/// Open url address in default internet browser.
		/// </summary>
		public IMvxCommand OpenUrlCommand => new MvxCommand<string>(async (url) => await Launcher.OpenAsync(url));

	}
}