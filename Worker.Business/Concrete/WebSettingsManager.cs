using System;
using System.Collections.Generic;
using System.Text;
using Worker.Business.Abstract;
using Worker.DataAccess.Abstract;
using Worker.Entities.Concrete;

namespace Worker.Business.Concrete
{
    public class WebSettingsManager : IWebSettingsService
    {
        private IWebSettingsDal _webSettingsDal;
        public WebSettingsManager(IWebSettingsDal webSettings)
        {
            _webSettingsDal = webSettings;
        }
        public WebSettings GetWebSettings(int WebSettingsId=1)
        {
           return _webSettingsDal.Get(x=>x.WebSettingsId==WebSettingsId);
        }
    }
}
