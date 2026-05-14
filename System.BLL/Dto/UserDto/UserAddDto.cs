namespace System.BLL
{
    public class UserAddDto:BaseDto
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Role { get; set; }
    }
}
