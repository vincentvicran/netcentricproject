using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using netcentricproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcentricproject.Controllers
{
    public class MarksController : Controller
    {
        private readonly netcentricprojectDBContext context;
        public MarksController(netcentricprojectDBContext _context)
        {
            context = _context;
        }
        public IActionResult MarksIndex()
        {
            List<MarksModel> marks =  ( from M in context.Markss
                                        join S in context.Students on M.StudentId equals S.StudentId 
                                        join Su in context.Subjects on M.SubjectId equals Su.SubjectId
                                        select new MarksModel()
            {
                MarksId = M.MarksId,
                StudentId = M.StudentId,
                StudentName = S.Name,
                SubjectName = Su.SubjectName,
                SubjectId = M.SubjectId,
                ObtainedMarks = M.ObtainedMarks
            }).ToList();
            return View(marks);
            
        }

        public IActionResult Create()
        {
            var Students = context.Students.Select(student => new StudentModel
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Roll = student.Roll,
            }).ToList();
            ViewBag.Students = new SelectList(Students, "StudentId", "Name");

            var Subject = context.Subjects.Select(x => new SubjectModel
            {
                SubjectId = x.SubjectId,
                SubjectName = x.SubjectName,
             
            }).ToList();
            ViewBag.Subjects= new SelectList(Subject, "SubjectId", "SubjectName");

           
            return View(new MarksModel());
        }
        [HttpPost]
        public IActionResult Create(MarksModel mark)
        {
            Marks markRow = new Marks();
            markRow.MarksId = mark.MarksId;
            markRow.StudentId = mark.StudentId;
            markRow.SubjectId = mark.SubjectId;
            markRow.ObtainedMarks= mark.ObtainedMarks;
            context.Markss.Add(markRow);
            context.SaveChanges();
            return RedirectToAction("MarksIndex");
        }

        public IActionResult Edit(int MarkId)
        {
            var Students = context.Students.Select(student => new StudentModel
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Roll = student.Roll,
            }).ToList();
            ViewBag.Students = new SelectList(Students, "StudentId", "Name");

            var Subject = context.Subjects.Select(x => new SubjectModel
            {
                SubjectId = x.SubjectId,
                SubjectName = x.SubjectName,

            }).ToList();
            ViewBag.Subjects = new SelectList(Subject, "SubjectId", "SubjectName");

            MarksModel marks = context.Markss.Where(x => x.MarksId == MarkId).Select(x => new MarksModel()
            {
                MarksId = x.MarksId,
               // StudentId = x.StudentId,
               // SubjectId = x.SubjectId,
                ObtainedMarks = x.ObtainedMarks,
            }).FirstOrDefault();
            
            return View(marks);
        }

        [HttpPost]
        public IActionResult Edit(MarksModel mark)
        {
            Marks markRow = new Marks();
            markRow.MarksId = mark.MarksId;
            markRow.StudentId = mark.StudentId;
            markRow.SubjectId = mark.SubjectId;
            markRow.ObtainedMarks = mark.ObtainedMarks;
            context.Markss.Attach(markRow);
            context.Entry(markRow).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("MarksIndex");
        }
        public IActionResult Delete(int MarkId)
        {
            MarksModel marks = context.Markss.Where(x => x.MarksId == MarkId).Select(x => new MarksModel()
            {
                MarksId = x.MarksId,
                StudentId = x.StudentId,
                SubjectId = x.SubjectId,
                ObtainedMarks = x.ObtainedMarks,
            }).FirstOrDefault();
            return View(marks);
        }


        [HttpPost]
        public IActionResult Delete(MarksModel marks)
        {
            Marks markRow = new Marks();
            markRow = context.Markss.Where(x => x.MarksId == marks.MarksId).FirstOrDefault();
            context.Markss.Remove(markRow);
            context.SaveChanges();
            return RedirectToAction("MarksIndex");
        }

        public IActionResult StudentMarks(int studentId)
        {

            String StdId = studentId.ToString();
            List<MarksModels> marks = context.MarksModels.FromSqlRaw(  "SpGetStudentMarks " + StdId).ToList();//Where//(x => x.StudentId == studentId).FirstOrDefault(); 
            return View(marks);
        }
        

    }
}
