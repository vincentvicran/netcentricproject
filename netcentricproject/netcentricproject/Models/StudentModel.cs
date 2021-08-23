using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace netcentricproject.Models
    
{
    public class StudentModel
    {
        public int StudentId { get; set; }

        [DisplayName("Full Name")]
        public string Name { get; set; }

        [DisplayName("Roll No.")]
        public int Roll { get; set; }
    }

  
  

    public  class MarksModel

    {
        public int MarksId { get; set; }
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string SubjectName { get; set; }
        public int SubjectId { get; set; }
        public decimal ObtainedMarks { get; set; }

    }
    public class SubjectModel

    {
       
        public int SubjectId { get; set; }
        public string SubjectName{ get; set; }

    }

}
