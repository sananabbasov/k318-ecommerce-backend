using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Core.Utilities.Results.Abstract;

public interface IDataResult<T> : IResult
{
    public T Data { get; }
}
