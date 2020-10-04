using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace XamarinAuthentication.Core.ViewModels.Dashboard
{
	public class DashboardViewModel: MvxNavigationViewModel
	{
		private readonly IMvxNavigationService _navigationService;

		public DashboardViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
		{
			this._navigationService = navigationService;
		}
	}
}