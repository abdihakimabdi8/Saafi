﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Saafi.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using System;
using System.Collections.ObjectModel;
using MvvmCross.Plugins.Messenger;
using Saafi.Core.Contracts.Services;
using Saafi.Core.Contracts.ViewModel;
using Saafi.Core.Extensions;
using Saafi.Core.Model;
using Saafi.Core.Model.App;

namespace Saafi.Core.ViewModel
{
    public class SendViewModel : BaseViewModel
    {
        public List<Recipient> AllRecipients { get; set; }
        private readonly ICityDataService _cityDataService;
        private readonly ICountryDataService _countryDataService;
        private readonly IServiceDataService _serviceDataService;
        private readonly IConnectionService _connectionService;
        private readonly IDialogService _dialogService;
        private Recipient _selectedRecipient;
        private Country _selectedCountry;
        private City _selectedCity;
        private Service _selectedService;

        private ObservableCollection<Country> _countries;
        private ObservableCollection<City> _cities;
        private ObservableCollection<Service> _services;

        private ObservableCollection<string> _possibleTimes;
        private string _sendContentTitle;
        private string _sendContentBody;

        public Recipient SelectedRecipient
        {
            get { return _selectedRecipient; }
            set
            {
                if (_selectedRecipient != value)
                {
                    _selectedRecipient = value;
                    RaisePropertyChanged(() => SelectedRecipient);
                }
            }
        }
        public Service SelectedService
        {
            get { return _selectedService; }
            set
            {
                if (_selectedService != value)
                {
                    _selectedService = value;
                    RaisePropertyChanged(() => SelectedService);
                }
            }
        }
        public Country SelectedCountry
        {
            get { return _selectedCountry; }
            set
            {
                if (_selectedCountry != value)
                {
                    _selectedCountry = value;
                    RaisePropertyChanged(() => SelectedCountry);
                }
            }
        }

        public City SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                if (_selectedCity != value)
                {
                    _selectedCity = value;
                    RaisePropertyChanged(() => SelectedCity);
                }
            }
        }
        public string SendContentTitle
        {
            get { return _sendContentTitle; }
            set
            {
                _sendContentTitle = value;
                RaisePropertyChanged(() => SendContentTitle);
            }
        }
        public string SendContentBody
        {
            get { return _sendContentBody; }
            set
            {
                _sendContentBody = value;
                RaisePropertyChanged(() => SendContentBody);
            }
        }
        public ObservableCollection<Service> Services
        {
            get { return _services; }
            set
            {
                _services = value;
                RaisePropertyChanged(() => Services);
            }
        }
        public ObservableCollection<Country> Countries
        {
            get { return _countries; }
            set
            {
                _countries = value;
                RaisePropertyChanged(() => Countries);
            }
        }
        public ObservableCollection<City> Cities
        {
            get { return _cities; }
            set
            {
                _cities = value;
                RaisePropertyChanged(() => Cities);
            }
        }
        public ObservableCollection<string> PossibleTimes
        {
            get { return _possibleTimes; }
            set
            {
                _possibleTimes = value;
                RaisePropertyChanged(() => PossibleTimes);
            }
        }

        public object RecipientName { get; private set; }
        public string CountryName { get; private set; }
        public string CityName { get; private set; }
        public string ServiceName { get; private set; }

        Send _send;


        public IMvxCommand SaveSend
        {
            get
            {
                return new MvxCommand(() =>
                {

                    _send.RecipientId = SelectedRecipient.RecipientId;
                    _send.CountryId = SelectedCountry.CountryId;
                    _send.CityId = SelectedCity.CityId;
                    _send.ServiceId = SelectedService.ServiceId;
                    _send.RecipientName = SelectedRecipient.RecipientName;
                    _send.CountryName = SelectedCountry.CountryName;
                    _send.CityName = SelectedCity.CityName;
                    _send.ServiceName = SelectedService.ServiceName;
                    Mvx.Resolve<SendRepository>().CreateSend(_send).Wait();
                 Close(this);
                });
            }
        }
        //public MvxCommand SendCommand
        //{
        //    get
        //    {
        //        return new MvxCommand(async () =>
        //        {
        //            Mvx.Resolve<SendRepository>().CreateSend(_send).Wait();
        //            Close(this);
        //            (_userDataService.GetActiveUser().UserId, SelectedRemittance.RemittanceId, SelectedRemittance.BeneficiaryId, SelectedRemittance.CountryId, SelectedRemittance.CityId, SelectedRemittance.ServiceId);

        //            //Hardcoded text, better with resx translations
        //            //await
        //            //    _dialogService.ShowAlertAsync("This journey is now in your Saved Journeys!", "My Trains says...", "OK");

        //            await
        //                _dialogService.ShowAlertAsync
        //                (TextSource.GetText("AddedToSavedRemittancesMessage"),
        //                 TextSource.GetText("AddedToSavedRemittancesTitle"),
        //                 TextSource.GetText("AddedToSavedRemittancesButton"));
        //        });
        //    }
        //}
      

        public SendViewModel(IMvxMessenger messenger,
            ICountryDataService countryDatasService,
            IServiceDataService serviceDatasService,

            ICityDataService cityDataService,
            IConnectionService connectionService,
            IDialogService dialogService) : base(messenger)
        {
            _countryDataService = countryDatasService;
            _serviceDataService = serviceDatasService;

            _cityDataService = cityDataService;
            _connectionService = connectionService;
            _dialogService = dialogService;

        }
        public override async void Start()
        {
            base.Start();

            await ReloadDataAsync();
        }


        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            if (_connectionService.CheckOnline())
            {
                await LoadCities();
                await LoadCountries();
                await LoadServices();

                //SelectedRecipient = AllRecipients[0];
                //SelectedCountry = Countries[0];
                //SelectedCity = Cities[0];
                //SelectedService = Services[0];
                //PossibleTimes = new ObservableCollection<string>();

                //RecipientName = SelectedRecipient.RecipientName;
                //CountryName = SelectedCountry.CountryName;
                //CityName = SelectedCity.CityName;
                //ServiceName = SelectedService.ServiceName;

            }
            else
            {
                await _dialogService.ShowAlertAsync("No internet available", "My Trains says...", "OK");
                //maybe we can navigate to a start page here, for you to add to this code base!
            }
        }

        internal async Task LoadCities()
        {
            Cities = (await _cityDataService.GetAllCities()).ToObservableCollection();
        }

        internal async Task LoadCountries()
        {
            Countries = (await _countryDataService.GetAllCountries()).ToObservableCollection();
        }
        internal async Task LoadServices()
        {
            Services = (await _serviceDataService.GetAllServices()).ToObservableCollection();
        }
       
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
           
        }
        public void Init(Send send = null)
        {
            Task<List<Recipient>> result = Mvx.Resolve<RecipientRepository>().GetAllRecipients();
            result.Wait();
            AllRecipients = result.Result;

           string  sendContentTitle = Mvx.Resolve<RecipientRepository>().GetSendContentTitle().ToString();
           string sendContentBody = Mvx.Resolve<RecipientRepository>().GetSendContentBody().ToString();

            SendContentTitle = sendContentTitle;
            SendContentBody = sendContentBody;
            _send = send == null ? new Send() : send;
            RaiseAllPropertiesChanged();
        }
    }
}

  