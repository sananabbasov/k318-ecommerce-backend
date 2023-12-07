using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Ecommerce.Core.Utilities.MailHelper;
using Ecommerce.Entities.Commands;
using MassTransit;

namespace Ecommerce.Business.Consumers;

public class SendEmailConsumer : IConsumer<SendEmailCommand>
{
    // private readonly IMailSender _mailSender;

    // public SendEmailConsumer(IMailSender mailSender)
    // {
    //     _mailSender = mailSender;
    // }

    public async Task Consume(ConsumeContext<SendEmailCommand> context)
    {
        // _mailSender.SendEmail(context.Message.Email, "Confirmation", "Content");
    }


}
