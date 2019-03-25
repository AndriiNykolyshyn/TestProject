using System;

namespace InternshipTest.Institution.InterLink
{
    public class Internship 
    {

        string Name;

        public Internship(string name)
        {
            Name = name;    
        }
        
        public void SetStudent(University student)
        {
            Name = student.GetName();
        }

        public string GetStudents()
        {
            return Name;
        }
    }
}
