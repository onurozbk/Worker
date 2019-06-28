using System;
using System.Collections.Generic;
using System.Text;
using Worker.Entities.Concrete;

namespace Worker.Business.Abstract
{
    public interface IWebSettingsService
    {
       WebSettings GetWebSettings(int WebSettingsId = 1);
    }
}
