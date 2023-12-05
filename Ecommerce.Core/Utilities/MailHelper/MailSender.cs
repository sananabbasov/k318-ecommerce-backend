using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Ecommerce.Core.Utilities.Results.Abstract;
using Ecommerce.Core.Utilities.Results.Concrete.ErrorResults;
using Ecommerce.Core.Utilities.Results.Concrete.SuccessResults;

namespace Ecommerce.Core.Utilities.MailHelper;

public class MailSender : IMailSender
{
    public IResult SendEmail(string receiverEmail, string subject, string body)
    {
        SmtpClient smtpClient = new SmtpClient("smtp.ethereal.email", 587);
        smtpClient.EnableSsl = true;
        smtpClient.Credentials = new NetworkCredential("harold.ebert@ethereal.email", "qczkpXRvKWn24Qzam1");

        try
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("harold.ebert@ethereal.email");
            mailMessage.To.Add(receiverEmail);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.IsBodyHtml = true;
            smtpClient.Send(mailMessage);
            return new SuccessResult();
        }
        catch (Exception e)
        {
            return new ErrorResult(e.Message);
        }
    }
}
