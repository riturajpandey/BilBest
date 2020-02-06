using BilBest.Providers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BilBest.BusinessCode
{
    public class BuisnessCode : IBusinessCode
    {
        IApiProvider _apiProvider;
        public BuisnessCode(IApiProvider apiProvider)
        {
            //To initialize service providers...
            _apiProvider = apiProvider;
            HttpClientHandler handler = new HttpClientHandler();
        }

        #region Web Services

        #endregion
    }
}
