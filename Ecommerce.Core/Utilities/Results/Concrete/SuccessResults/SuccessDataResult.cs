using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Core.Utilities.Results.Concrete.SuccessResults;

public class SuccessDataResult<T> : DataResult<T>
{
    public SuccessDataResult(T data) : base(data, true)
    {
    }

    public SuccessDataResult(T data, string message) : base(data, true, message)
    {
    }
}
