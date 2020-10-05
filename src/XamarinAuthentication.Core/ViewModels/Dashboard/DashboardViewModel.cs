using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using XamarinAuthentication.Core.Services.DataService;

namespace XamarinAuthentication.Core.ViewModels.Dashboard
{
	public class DashboardViewModel: MvxNavigationViewModel
	{
		private readonly IExampleDataService _exampleDataService;

		public List<string> Cities { get; set; }

		public DashboardViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IExampleDataService exampleDataService) : base(logProvider, navigationService)
		{
			this._exampleDataService = exampleDataService;
		}

		public override Task Initialize()
		{
			this.Cities = this._exampleDataService.GetCities();
			this.RaisePropertyChanged(nameof(this.Cities));

			return base.Initialize();
		}
	}
}