using SqlSugar;

namespace System.Model.Entity
{
    [SugarTable("user")]
    public class UserEntity : BaseEntity
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Role { get; set; }
    }
}
