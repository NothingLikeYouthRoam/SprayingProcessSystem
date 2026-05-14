using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace System.Model
{
    public class BaseEntity
    {
        [SugarColumn(IsPrimaryKey =true, IsIdentity =true)]
        public int Id { get; set; }
    }
}
