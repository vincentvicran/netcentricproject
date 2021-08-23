using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    [Table("Student", Schema = "dbo")]
    public partial class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Roll { get; set; }        
    }

    [Table("Marks", Schema = "dbo")]
    public partial class Marks
    {
        public int MarksId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public decimal ObtainedMarks{ get; set; }
    }

    [Table("Subject", Schema = "dbo")]
    public partial class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
    }

    public class MarksModels
    {
        public int MarksId { get; set; }
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string SubjectName { get; set; }
        public int SubjectId { get; set; }
        public decimal ObtainedMarks { get; set; }
    }
}
