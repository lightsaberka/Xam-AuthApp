using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using XamarinAuthentication.Core.ViewModels.Dashboard;
using XamarinAuthentication.Core.ViewModels.UserProfile;

namespace XamarinAuthentication.Core.ViewModels.Tabs
{
	public class TabsRootViewModel: MvxNavigationViewModel
	{
		private readonly IMvxNavigationService _navigationService;

		public TabsRootViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
		{
			this._navigationService = navigationService;
			
			this.AllTabs = new List<Type>
			{
				typeof(DashboardViewModel),
				typeof(UserViewModel)
			};

			this.ShowTabsCommand = new MvxAsyncCommand(this.InitializeTabs);
		}

		/// <summary>
		/// List of tabs.
		/// </summary>
		public List<Type> AllTabs { get; }

		public IMvxAsyncCommand ShowTabsCommand { get; }

		/// <summary>
		/// Initialize tabs for navigation.
		/// </summary>
		/// <returns></returns>
		public Task InitializeTabs()
		{
			var tasks = new List<Task>();

			foreach (var tab in this.AllTabs) {
				tasks.Add(this._navigationService.Navigate(tab));
			}
			return Task.WhenAll(tasks);
		}
	}
}