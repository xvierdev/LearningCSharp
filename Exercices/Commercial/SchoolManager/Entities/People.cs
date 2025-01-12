using System;

namespace SchoolManager.Entities
{
    class People
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime Birthday { get; set; }

        public People()
        {

        }

        public People(string name, string email, int phone, DateTime birthday)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Birthday = birthday;
        }
    }
}