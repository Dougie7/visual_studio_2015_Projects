using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */
            Student student1 = new Student() {StudentId=100,Name="Doug" };
            Student student2 = new Student() { StudentId = 101, Name = "Dan" };
            Student student3 = new Student() { StudentId = 102, Name = "Jan" };
            Student student4 = new Student() { StudentId = 103, Name = "Bobby" };
            Student student5 = new Student() { StudentId = 104, Name = "Chris" };
            Student student6 = new Student() { StudentId = 105, Name = "Tom" };

            List<Course> Courses = new List<Course>()
            {
                new Course() {CourseId=1, Name="Bull",Students=new List<Student> { student1,student2 } },
                new Course() {CourseId=2, Name="Bullstuff",Students=new List<Student> { student3,student4 } },
                new Course() {CourseId=3, Name="DoubleBull",Students=new List<Student> { student5,student6 } }
            };

            foreach (var course in Courses)
            {
                resultLabel.Text += String.Format("<br/>Course: {0} - {1}",course.CourseId,course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("<br/>  Student: {0} - {1}", student.StudentId, student.Name);
                }
            }
            }
   

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Course course1 = new Course() { CourseId=500,Name="Again" };
            Course course2 = new Course() { CourseId = 501, Name = "What?" };
            Course course3 = new Course() { CourseId = 502, Name = "Oh Yeah" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {123,new Student {StudentId=123,Name="Biff",Courses=new List<Course> {course1,course2 } } },
                {456,new Student {StudentId=456,Name="Moron",Courses=new List<Course> {course2, course3 } } },
                {789, new Student {StudentId=789,Name="Fried",Courses=new List<Course> {course1, course3 } } } 
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br/>Student: {0} - {1}",student.Value.StudentId,student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br/>  Course: {0} - {1}", course.CourseId, course.Name);
                }
            }

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */
            Course course1 = new Course() { CourseId = 500, Name = "Again" };
            Course course2 = new Course() { CourseId = 501, Name = "What?" };

            Student student1 = new Student() { StudentId = 100, Name = "Doug" };


            student1.Grades = new List<Grade>()
            {
                new Grade {course= course1,student=student1,coursegrade=95 },
                new Grade {course= course2,student=student1,coursegrade=85 },
            };

            resultLabel.Text = string.Format("Student: {0}", student1.Name);
            foreach (var grade in student1.Grades)
            {
                resultLabel.Text += string.Format("<br/>Course: {0}  Grade: {1}",grade.course.Name,grade.coursegrade);
            }
        }
    }
}