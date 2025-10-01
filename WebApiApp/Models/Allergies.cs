namespace WebApiApp.Models
{
    public class Allergies
    {
        public string StudentSsn { get; set; }
        public string Allergy { get; set; }
        public enum Severity
        {
            Light,
            Moderate,
            Severe
        }
    }
}
