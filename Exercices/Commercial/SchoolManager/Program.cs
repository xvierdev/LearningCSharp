using System;
using SchoolManager.Entities;
namespace SchoolManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new("Wesley", "wesley.xvier@gmail.com", "12997257997", DateTime.Parse("04/02/1992"));
            Student student = new("Iago", "iago@gmail.com", "12988887777", DateTime.Parse("20/03/2010"), Entities.Enums.Course.Hardware);
        }
    }
}   