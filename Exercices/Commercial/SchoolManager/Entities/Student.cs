using System;
using SchoolManager.Entities.Enums;

namespace SchoolManager.Entities
{
    class Student : People
    {
        public Course Course { get; set; }
        public Student()
        {

        }
        public Student(string name, string email, string phone, DateTime birthday, Course course) : base (name, email, phone, birthday){
            Course = course;
        }
    }
}