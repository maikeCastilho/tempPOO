using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollegeOOP
{
    public class Teacher
    {
        public int id;
        public string name;
        public string email;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Teacher(int id, string name, string email, string courses)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email; 
        }
    }
}
