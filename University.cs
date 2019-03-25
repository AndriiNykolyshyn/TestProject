using InternshipTest.Person;
using System.Collections.Generic;
using System;
using InternshipTest.Institution.InterLink;

namespace InternshipTest.Institution
{
    public class University
    {
        string Name;
        public string student;
        List<string> Student = new List<string>();
        List<int> Knowledge = new List<int>();

        public University(){ }
        public University(string name)
        {
            Name = name; 
        }

        public void AddStudent(Student student)
        {
            Console.WriteLine("Set Knowledge");
            int c = 0;

            c = Convert.ToInt32(Console.ReadLine());
            student.SetKnowledge(new Knowledge(c));

            Student.Add(student.GetName());
            Knowledge.Add(c);

        }
        int Mid;
        public int MidKnowledge()
        {
            foreach (int k in Knowledge)
            {
                Mid += k;
            }
            Mid = Mid / Student.Count;
            return Mid;
        }
        public void GetStudent()
        {
            Mid = MidKnowledge();
            for (int i = 0; i < Knowledge.Count; i++)
            {
                if (Knowledge[i] >= Mid)
                {
                    student = student + Student[i] + " ";
                }
            }
        }
        public string GetName()
        {
            return Name;
        }
        public string WriteStudent()
        {
            GetStudent();
            return student;
        }

    }
}
