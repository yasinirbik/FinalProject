using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        //IResult'taki success ve message'ı IResult ile adık ve tekrar yazmamıza gerek kalmadı
        T Data { get; }

    }
}
