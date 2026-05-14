using System;
using System.Collections.Generic;
using System.Text;

namespace System.Helper
{
    public class BaseResult
    {
        public SystemEnums.Result Status { get; set; } = SystemEnums.Result.Success;

        public string Msg { get; set; } = string.Empty;
    }

    public class BaseResult<T>: BaseResult
    {
        public List<T> Data { get; set; }
    }
}
