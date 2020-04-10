using System.Collections.Generic;

namespace Gradebook.Models
{
    public class Student
    {
        public string FullName { get; set; }
        public string DOB { get; set; }
        public string Group { get; set; }

        public Student(string FullName, string DOB, string Group)
        {
            this.FullName = FullName;
            this.DOB = DOB;
            this.Group = Group;
        }

        public string Hash
        {
            get
            {
                var names = FullName.Split(" ");
                var fullName = names[0][0].ToString() + names[1][0].ToString();
                var year = DOB[DOB.Length - 2].ToString() + DOB[DOB.Length - 1].ToString();
                var month =  DOB[DOB.Length - 7].ToString() + DOB[DOB.Length - 6].ToString();
                var group = Group[Group.Length - 3].ToString() + Group[Group.Length - 2].ToString() + Group[Group.Length - 1].ToString();
                return fullName + year + group;
            }
        }
    }
}