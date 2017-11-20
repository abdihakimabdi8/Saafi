using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Saafi.Core.Models;
using Saafi.Core.Services;
using System.Windows.Input;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Saafi.Core.ViewModel
{
    public class RecipientViewModel : MvxViewModel
    {
        Recipient _recipient;
        private string _recipientName;
        private string _recipientPhoneNumber;
        public string RecipientName
        {
            get { return _recipientName; }
            set
            {
                _recipientName = value;
                RaisePropertyChanged(() => RecipientName);
            }
        }
        public string RecipientPhoneNumber
        {
            get { return _recipientPhoneNumber; }
            set
            {
                _recipientPhoneNumber = value;
                RaisePropertyChanged(() => RecipientPhoneNumber);
            }
        }
        public ICommand NavBack
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }
        public MvxCommand CloseCommand
        { get { return new MvxCommand(() => Close(this)); } }
        public MvxCommand SaveRecipient
        {
            get
            {
                return new MvxCommand(() => {
                    if (_recipient.IsValid())
                    {
                        _recipient.RecipientName = _recipientName;
                        _recipient.RecipientPhoneNumber = _recipientPhoneNumber;
                        Mvx.Resolve<RecipientRepository>().CreateRecipient(_recipient).Wait();
                        Close(this);
                    }
                });

            }
        }
        public void Init(Recipient recipient = null)
        {
            _recipient = recipient == null ? new Recipient() : recipient;
            RaiseAllPropertiesChanged();
        }
    }
}