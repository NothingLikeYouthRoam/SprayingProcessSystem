using System;
using System.Collections.Generic;
using System.Text;

namespace System.BLL
{
    public class QueryUserResultDto:BaseDto
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Role { get; set; }
    }
}
