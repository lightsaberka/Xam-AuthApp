using System;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using XamarinAuthentication.Core.ViewModels.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAuthentication.UI.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	[MvxContentPagePresentation(WrapInNavigationPage = true)]
	public partial class HomePage : MvxContentPage<HomeViewModel>
	{
		public HomePage()
		{
			this.InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (Application.Current.MainPage is NavigationPage navigationPage) {
				navigationPage.BarTextColor = Color.White;
				navigationPage.BarBackgroundColor = (Color) Application.Current.Resources["PrimaryColor"];
			}
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			this.ViewModel.Authenticate();
		}
	}
}
