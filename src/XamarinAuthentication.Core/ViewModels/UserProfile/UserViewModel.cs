using System.Threading.Tasks;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
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
	}
}