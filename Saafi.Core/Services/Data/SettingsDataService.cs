using System.Collections.Generic;
using Saafi.Core.Contracts.Repository;
using Saafi.Core.Contracts.Services;
using Saafi.Core.Model;

namespace Saafi.Core.Services.Data
{
    public class SettingsDataService : ISettingsDataService
    {
        private readonly ISettingsRepository _settingsRepository;
        private Currency _activeCurrency;

        public SettingsDataService(ISettingsRepository settingsRepository)
        {
            _settingsRepository = settingsRepository;
        }

        public List<Currency> GetCurrencies()
        {
            return _settingsRepository.GetAvailableCurrencies();
        }

        public Currency GetActiveCurrency()
        {
            return _activeCurrency ?? (_activeCurrency = _settingsRepository.GetCurrencyById(1));
        }

        public void SetActiveCurrency(Currency currency)
        {
            _activeCurrency = currency;
        }

        public string GetAboutContent()
        {
            return _settingsRepository.GetAboutContent();
        }
    }
}