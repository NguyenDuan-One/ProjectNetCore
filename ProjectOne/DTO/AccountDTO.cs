namespace ProjectOne.DTO
{
    public class AccountDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }

    public class AccountLoginRequestData
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}