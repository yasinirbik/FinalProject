using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)//This bu classı kastetmekte. Result'ın tek parametreli(success) constructor'ını ççalıştırmakta.DRY (bu constructor'ın altına success = Success yazılabilirdi fakat aşağıda zaten yapılmış kendizmiz tekrar etmeden bu şekilde kullanım yapabilmekteyiz.)
        {
            Message = message;
        }
        public Result (bool success)//doğruluk kontroluamaçlı constructor'ımız  
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }//get readonly^'dir lakin Constructor'larda set edilebilir.
    }
}
