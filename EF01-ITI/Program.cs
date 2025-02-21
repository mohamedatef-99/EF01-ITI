using EF01_ITI.Configuration;
using EF01_ITI.Contexts;
using EF01_ITI.Entities;

namespace EF01_ITI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDBContext context = new AppDBContext();

            #region Create - Insert
            // Create - Insert

            //var student01 = new Student()
            //{
            //    FName = "ahmed",
            //    LName = "Ali",
            //    Address = "cairo",
            //    Age = 25
            //};
            //var student02 = new Student()
            //{
            //    FName = "mohamed",
            //    LName = "ahmed",
            //    Address = "alx",
            //    Age = 20
            //};

            //var course = new Course()
            //{
            //    Name = "C#",
            //    Description = "Dot net",
            //    Duration = 20,
            //    Top_Id = 1,
            //};

            //var course_ins = new Course_Inst() { Course_Id = 1, Evaluate = "dsf" };
            //var department = new Department() { Name = "floor", Ins_Id= 1, Hiring_Date = DateTime.Now };
            //var insturctor = new Instructor() { Name = "Ahmed ali", Address = "cairo", Bouns = 10, Dept_Id = 1, Houre_Rate = 10, Salary = 1000 };
            //var stud_course = new Stud_Course() { Course_Id = 1, Grade = 100 };
            //var topic = new Topic() { Name = "ORM" };


            //context.Students.Add(student01);
            //context.Students.Add(student02);

            //context.courses.Add(course);

            //context.course_Insts.Add(course_ins);
            //context.departments.Add(department);
            //context.Add(insturctor);
            //context.Add(stud_course);
            //context.Add(topic); 
            #endregion

            #region Read - Select
            // Read - Select

            //var course = context.courses.FirstOrDefault(C => C.Id == 1);
            //Console.WriteLine(course.Name);

            //var course_inst = context.course_Insts.FirstOrDefault(C => C.Ins_Id == 1);
            //Console.WriteLine(course_inst.Evaluate);

            //var department = context.departments.Where(D => D.Name == "floor");
            //foreach (var item in department)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var stud_course = context.Student_Courses.FirstOrDefault(S => S.Stud_Id == 2);
            //Console.WriteLine(stud_course.Course_Id);

            //var student = context.Students.Where(S => S.Id == 1).Select(S => S.Address);
            //foreach (var item in student)
            //{
            //    Console.WriteLine(item);
            //}

            //var topic = context.topics.FirstOrDefault(T => T.Id == 3);
            //Console.WriteLine(topic.Name); 
            #endregion


            //context.SaveChanges();

        }
    }
}
