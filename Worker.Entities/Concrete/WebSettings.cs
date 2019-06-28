using System;
using System.Collections.Generic;
using System.Text;
using Worker.Core.Entities;

namespace Worker.Entities.Concrete
{
   public class WebSettings:IEntity
    {
        public int WebSettingsId { get; set; }
        public string MailTemplate { get; set; }
        public string MailAdress { get; set; }
        public string MailPassword { get; set; }
    }
}
