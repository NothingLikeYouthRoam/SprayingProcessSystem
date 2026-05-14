using System;
using System.Collections.Generic;
using System.Text;

namespace System.BLL
{
    public class QueryDataDto : BaseDto
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
