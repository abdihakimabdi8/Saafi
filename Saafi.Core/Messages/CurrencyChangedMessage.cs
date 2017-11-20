using MvvmCross.Plugins.Messenger;
using Saafi.Core.Model;

namespace Saafi.Core.Messages
{
    public class CurrencyChangedMessage: MvxMessage
    {
        public CurrencyChangedMessage(object sender) : base(sender)
        {
        }

        public Currency NewCurrency { get; set; }
    }
}