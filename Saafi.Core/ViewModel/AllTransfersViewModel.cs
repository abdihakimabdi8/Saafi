﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Saafi.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Saafi.Core.ViewModel
{
    public class AllTransfersViewModel : MvxViewModel
    {
        public List<Transfer> AllTransfers { get; set; }

        public ICommand NavBack
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }

        // This is another place that could be improved.
        // We are using the async capabilities built in to SQLite-Net,
        // but in this example, we simply wait for the thread to complete.
        public void Init()
        {
            Task<List<Transfer>> result = Mvx.Resolve<TransferRepository>().GetAllTransfers();
            result.Wait();
            AllTransfers = result.Result;
        }
    }
}