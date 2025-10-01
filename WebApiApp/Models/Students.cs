namespace WebApiApp.Models
{
    public class Students
    {
        public string Name { get; set; }
        public string StudentSsn { get; set; }
        public string TeacherSsn { get; set; }
        public string Parent1Ssn { get; set; }
        public string Parent2Ssn { get; set; }
        public enum GL
        {
            Infant,
            Kindergarten,
            Elementary
        }
        public GL GradeLevel { get; set; }
        public string GradeSubLevel { get; set; }
    }
}
