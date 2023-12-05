using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.Utilities.Results.Abstract;

namespace Ecommerce.Core.Utilities.MailHelper;

public interface IMailSender
{
    IResult SendEmail(string receiverEmail, string subject, string body);
}
