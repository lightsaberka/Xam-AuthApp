using MvvmCross.IoC;
using MvvmCross.ViewModels;
using XamarinAuthentication.Core.ViewModels.Home;

namespace XamarinAuthentication.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
	        this.CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

	        this.RegisterAppStart<HomeViewModel>();
        }
    }
}
