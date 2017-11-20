using System;
using System.Collections.Generic;
using Saafi.Core.Model;
using Saafi.Core.Models;

namespace Saafi.Core.Contracts.Repository
{
    public interface ISettingsRepository
    {
        List<Currency> GetAvailableCurrencies();
        Currency GetCurrencyById(int currencyId);

        string GetAboutContent();
    }
}
