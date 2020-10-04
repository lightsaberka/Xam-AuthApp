using System.Threading.Tasks;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using XamarinAuthentication.Core.Models;
using XamarinAuthentication.Core.Services.UserProfile;

namespace XamarinAuthentication.Core.ViewModels.UserProfile
{
	public class UserViewModel: MvxNavigationViewModel
	{
		private readonly IUserDataService _userDataService;

		public User CurrentUser { get; set; }

		public UserViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IUserDataService userDataService) 
			: base(logProvider, navigationService)
		{
			this._userDataService = userDataService;
		}

		public override Task Initialize()
		{
			this.CurrentUser = this._userDataService.GetUser();
			this.RaisePropertyChanged(nameof(this.CurrentUser));

			return base.Initialize();
		}
	}
}