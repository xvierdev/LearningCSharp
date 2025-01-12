using System;
using System.Collections.Generic;
using SchoolManager.Entities.Enums;

namespace SchoolManager.Entities
{
    class Teacher : People
    {
        public HashSet<Course> Courses = [];
        public Teacher()
        {

        }
        public Teacher(string name, string email, string phone, DateTime birthday) : base(name, email, phone, birthday)
        {

        }
        public void AddCourse (Course course)
        {
            Courses.Add(course);
        }
    }
}