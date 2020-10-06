using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinAuthentication.Core.Models;
using XamarinAuthentication.Core.Services.DataService;

namespace XamarinAuthentication.Core.ViewModels.UserProfile
{
	public class UserViewModel: MvxNavigationViewModel
	{
		private readonly IExampleDataService _exampleDataService;

		public User CurrentUser { get; set; }

		public UserViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IExampleDataService exampleDataService) 
			: base(logProvider, navigationService)
		{
			this._exampleDataService = exampleDataService;
		}

		public override Task Initialize()
		{
			this.CurrentUser = this._exampleDataService.GetUser();
			this.RaisePropertyChanged(nameof(this.CurrentUser));

			return base.Initialize();
		}

		/// <summary>
		/// Open default e-mail application to send e-mail to provided e-mail address.
		/// note: On iOS this works only on real device, not simulator.
		/// </summary>
		public ICommand OpenEmailCommand => new Command<string>(async (email) => await Launcher.OpenAsync($"mailto:{email}"));

	}
}