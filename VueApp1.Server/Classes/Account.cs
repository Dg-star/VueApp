namespace VueApp1.Server.Classes
{
    public class Account
    {
        public int account_id { get; set; }
        public int status_id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime password_expiration_date { get; set; }
        public int account_expiration_date_id { get; set; }
        public int user_id { get; set; }
        public int x_storage_id { get; set; }
    }
}
