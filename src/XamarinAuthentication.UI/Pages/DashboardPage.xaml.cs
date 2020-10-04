using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;
using XamarinAuthentication.Core.ViewModels.Dashboard;

namespace XamarinAuthentication.UI.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	[MvxTabbedPagePresentation(WrapInNavigationPage = false, Title = "Dashboard")]
	public partial class DashboardPage : MvxContentPage<DashboardViewModel>
	{
		public DashboardPage()
		{
			this.InitializeComponent();
		}
	}
}