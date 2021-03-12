using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler  için başlangıç
    public interface IResult
    {
        bool Success { get; }//Get demek okunabilir ,set yazılabilir demekti.
        string Message { get; }

    }
}
