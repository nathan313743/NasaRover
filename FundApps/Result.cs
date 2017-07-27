using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundApps
{
    public class Result
    {
        public bool IsOk { get; private set; }

        public bool IsFail => !IsOk;

        public static Result Ok()
        {
            var result = new Result();
            result.IsOk = true;
            return result;
        }

        public static Result Fail()
        {
            var result = new Result();
            return result;
        }
    }
}