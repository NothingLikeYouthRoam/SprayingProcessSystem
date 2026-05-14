using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace System.Model.Entity
{
    [SugarTable("data")]
    public class DataEntity : BaseEntity
    {

        public DateTime InsertTime { get; set; }

        public string? 脱脂喷淋泵压力值 { get; set; }

        public string? 脱脂pH值 { get; set; }
        public string? 陶化pH值 { get; set; }

        public string? 粗洗喷淋泵压力值 { get; set; }

        public string? 陶化喷淋泵压力值 { get; set; }

        public string? 精洗喷淋泵压力值 { get; set; }

        public string? 水分炉测量温度 { get; set; }

        public string? 固化炉测量温度 { get; set; }

        public string? 厂内温度 { get; set; }

        public string? 厂内湿度 { get; set; }
    }
}
