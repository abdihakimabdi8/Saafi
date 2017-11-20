using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Saafi.Core.Contracts.ViewModel;

namespace Saafi.Core.ViewModel
{
    public class MainViewModel : MvxViewModel, IMainViewModel
    {

        private readonly Lazy<SettingsViewModel> _settingsViewModel;
        private readonly Lazy<SendViewModel> _sendViewModel;
        private readonly Lazy<AllSendsViewModel> _allSendsViewModel;
        private readonly Lazy<AllRecipientsViewModel> _allRecipientsViewModel;
        private readonly Lazy<RecipientViewModel> _recipientViewModel;


        public SendViewModel SendViewModel => _sendViewModel.Value;


        public SettingsViewModel SettingsViewModel => _settingsViewModel.Value;
        public AllSendsViewModel AllSendsViewModel => _allSendsViewModel.Value;
        public AllRecipientsViewModel AllRecipientsViewModel => _allRecipientsViewModel.Value;
        public RecipientViewModel RecipientViewModel => _recipientViewModel.Value;


        public MainViewModel()
        {
            _sendViewModel = new Lazy<SendViewModel>(Mvx.IocConstruct<SendViewModel>);
            _settingsViewModel = new Lazy<SettingsViewModel>(Mvx.IocConstruct<SettingsViewModel>);
            _allSendsViewModel = new Lazy<AllSendsViewModel>(Mvx.IocConstruct<AllSendsViewModel>);
            _allRecipientsViewModel = new Lazy<AllRecipientsViewModel>(Mvx.IocConstruct<AllRecipientsViewModel>);
            _recipientViewModel = new Lazy<RecipientViewModel>(Mvx.IocConstruct<RecipientViewModel>);

        }

        public void ShowMenu()
        {
            ShowViewModel<MenuViewModel>();
        }

        public void ShowSendRemittances()
        {
            ShowViewModel<SendViewModel>();
        }
    }
}