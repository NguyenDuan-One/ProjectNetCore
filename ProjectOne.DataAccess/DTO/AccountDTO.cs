namespace ProjectOne.DataAccess.DTO
{
    public class AccountDTO
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string FullName { get; set; }
    }

    public class AccountLoginRequestData
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }
}