using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Saafi.Core.Contracts.Services;
using Saafi.Core.ViewModel;

namespace Saafi.Core
{
    public class AppStart: MvxNavigatingObject, IMvxAppStart
    {
        public async void Start(object hint = null)
        {
            //hardcoded login for this demo
            var userService = Mvx.Resolve<IUserDataService>();
            await userService.Login("gillcleeren", "123456");

            ShowViewModel<MainViewModel>();
        }
    }
}
