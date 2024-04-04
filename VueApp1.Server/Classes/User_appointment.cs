namespace VueApp1.Server.Classes
{
    public class User_appointment
    {
        public int user_id { get; set; }
        public int personnel_appointment_id { get; set; }
        public DateTime date_of_dismissal { get; set; }
        public DateTime date_of_receipt { get; set; }
        public int type_id {  get; set; }
    }
}
