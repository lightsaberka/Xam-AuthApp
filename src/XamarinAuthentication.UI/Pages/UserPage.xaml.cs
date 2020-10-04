using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;
using XamarinAuthentication.Core.ViewModels.UserProfile;

namespace XamarinAuthentication.UI.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	[MvxTabbedPagePresentation(WrapInNavigationPage = false, Title = "Profile")]
	public partial class UserPage : MvxContentPage<UserViewModel>
	{
		public UserPage()
		{
			this.InitializeComponent();
		}
	}
}