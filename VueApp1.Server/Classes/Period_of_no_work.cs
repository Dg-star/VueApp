namespace VueApp1.Server.Classes
{
    public class Period_of_no_work
    {
        public int period_of_no_work_id {  get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set;}
        public string problem {  get; set; }
        public int user_id { get; set; }
        public int personnel_appointment_id { get; set; }

    }
}
