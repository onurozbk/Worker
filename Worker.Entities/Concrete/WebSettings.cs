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
        public string SmtpMail { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpPort { get; set; }
        public bool SmtpSSL { get; set; }
        public string SmptAdress { get; set; }
        public string CustomerAddedTemplate { get; set; }
        public string ActivityAddedTemplate { get; set; }
    }
}
