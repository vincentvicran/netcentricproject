using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DAL;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using netcentricproject.Models;


namespace netcentricproject.Controllers
{
    public class StudentController : Controller
    {
        private netcentricprojectDBContext context;
        public StudentController(netcentricprojectDBContext _context)
        {
            context = _context ?? throw new ArgumentNullException(nameof(_context));
        }
      
        public IActionResult ClassIndex()
        {
            string datasource = @"StudentDBConnection";
            List<StudentModel> classes = new List<StudentModel>();
            SqlConnection sqlConnection = new SqlConnection(datasource);
            
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Student", sqlConnection);//it is a sql command to execute in database
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // its a buffer to hold data from database
            DataTable dataTable = new DataTable(); //its is data type, like integer
            sqlDataAdapter.Fill(dataTable); //fill the datatable from the buffer
            sqlConnection.Close();
            return View(dataTable);
        }
        
        public IActionResult AddUpdateClass(int? ClassId)
        {
            StudentModel classModel = new StudentModel();

            return View(classModel);
        }
        
        [HttpPost]
        public IActionResult AddUpdateClass(StudentModel classModel)
        {
            using (SqlConnection sqlConnection = new SqlConnection("StudentDBConnection"))
            {
                /*E:\Project\netcentricproject\netcentricproject\DAL\Database.mdf E:\\Project\\netcentricproject\\netcentricproject\\DAL\\Database.mdf;*/
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert into Student(Name,Roll) values ('"+classModel.Name+"', '"+classModel.Roll+"')", sqlConnection); //it is a sql command to execute in database
                int affectedRows = sqlCommand.ExecuteNonQuery();
               // sqlConnection.Close();
                return RedirectToAction("ClassIndex");
            }
        }

        public IActionResult Create()
        {

            return View(new StudentModel()); 
        }
        [HttpPost]
        public IActionResult Create(StudentModel student)
        {
           Student studentRow = new Student();
           studentRow.StudentId = student.StudentId;
           studentRow.Name = student.Name;
           studentRow.Roll = student.Roll;
            context.Students.Add(studentRow);
            context.SaveChanges();
            return RedirectToAction("Students");
        }
        public IActionResult Edit(int studentId)
        {
            StudentModel student = context.Students.Where(x => x.StudentId == studentId).Select(x => new StudentModel()
            {
                StudentId = x.StudentId,
                Name = x.Name,
                Roll = x.Roll,
            }).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(StudentModel student)
        {
            Student studentRow = new Student();
            studentRow.StudentId = student.StudentId;
            studentRow.Name = student.Name;
            studentRow.Roll = student.Roll;
            context.Students.Attach(studentRow);
            context.Entry(studentRow).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("students");
        }

        public IActionResult Delete(int StudentID)
        {
            StudentModel student = context.Students.Where(x => x.StudentId == StudentID).Select(x => new StudentModel()
            {
                StudentId = x.StudentId,
                Name = x.Name,
                Roll = x.Roll,
            }).FirstOrDefault();
            return View(student); 
        }

        [HttpPost]
        public IActionResult Delete(StudentModel student)
        {
            Student studentRow = new Student();
            studentRow = context.Students.Where(x => x.StudentId == student.StudentId).FirstOrDefault();
            context.Students.Remove(studentRow);
            context.SaveChanges();
            return RedirectToAction("students");
        }



        public IActionResult Students()
        {
            List<StudentModel> students = context.Students.Select(student => new StudentModel()
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Roll = student.Roll,
            }).ToList();
            return View(students);
        }
    }


}