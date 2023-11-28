using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Core.Utilities.Results.Concrete.ErrorResults;

public class ErrorDataResult<T> : DataResult<T>
{
    public ErrorDataResult(T data) : base(data, false)
    {
    }

    public ErrorDataResult(T data, string message) : base(data, false, message)
    {
    }
}
