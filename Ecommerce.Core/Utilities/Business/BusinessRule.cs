using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.Utilities.Results.Abstract;
using Ecommerce.Core.Utilities.Results.Concrete.ErrorResults;
using Ecommerce.Core.Utilities.Results.Concrete.SuccessResults;

namespace Ecommerce.Core.Utilities.Business;

public class BusinessRule
{
    public static IResult Run(params IResult[] results)
    {
        foreach (var result in results)
        {
            if (!result.Success)
            {
                return new ErrorResult();
            }
        }
        return new SuccessResult();
    }
}
