using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.Commands;
using MassTransit;

namespace Ecommerce.Business.Consumers;

public class SendEmailConsumer : IConsumer<SendEmailCommand>
{
    public Task Consume(ConsumeContext<SendEmailCommand> context)
    {
        throw new NotImplementedException();
    }
}
