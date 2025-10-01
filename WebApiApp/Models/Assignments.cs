namespace WebApiApp.Models
{
    public class Assignments
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public enum GL
        { 
            Infant,
            Kindergarten,
            Elementary
        }
        public GL GradeLevel { get; set; }

        public string GradeSubLevel { get; set; }
        public string Instructions { get; set; }
        public byte[] AssignmentFile { get; set; }
    }
}
