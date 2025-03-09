using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterBackend;

public class CurrencyRepository
{
    public List<Currency> GetCurrencies()
    {
        List<Currency> currencies = new List<Currency>();
        currencies.Add(new Currency("Romanian Lei", "RON", 1m));
        currencies.Add(new Currency("Euro", "EUR", 0.2009m));
        currencies.Add(new Currency("American Dollar", "USD", 0.2115m));
        currencies.Add(new Currency("Pound Sterling", "GBP", 0.1663m));
        currencies.Add(new Currency("Swiss Franc", "CFH", 0.1873m));
        currencies.Add(new Currency("Moldovan Lei", "MDL", 3.8646m));
        currencies.Add(new Currency("Canadian Dollar", "CAD", 0.2967m));
        currencies.Add(new Currency("Australian Dollar", "AUD", 0.3257m));
        currencies.Add(new Currency("Dirham EAU", "AED", 3.8666m));
        currencies.Add(new Currency("Japanese Yen", "JPY", 31.7551m));
        currencies.Add(new Currency("Indian Rupee", "INR", 17.9147m));

        return currencies;
    }

    public int GetCurrencyIndexByAbbreviation(string abbreviation)
    {
        List<Currency> currencies = GetCurrencies();
        for (int i = 0; i < currencies.Count; i++)
        {
            Currency currency = currencies[i];
            if (abbreviation.Equals(currency.Abbreviation))
            {
                return i;
            }
        }

        return 0;
    }
}
