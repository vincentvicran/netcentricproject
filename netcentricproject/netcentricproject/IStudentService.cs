using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcentricproject
{
    interface IStudentService
    {
        List<StudentModel> GetStudentsFromDB();

     
    }
}
