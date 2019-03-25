using System;
using System.Collections.Generic;

namespace InternshipTest.Person 
{ 
    public class Student
    {
        string Name;
        public Student(string name)
        {
            Name = name;
        }
        public void SetKnowledge(Knowledge knowledge)
        {
            knowledge.GetKnowledge();
        }
        public string GetName()
        {
            return Name;
        }
    }
}