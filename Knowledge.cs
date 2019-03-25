using System;
using System.Collections.Generic;
namespace InternshipTest
{
    public class Knowledge
    { 
        int Level;
        public Knowledge(int level)
        {
            Level = level;
        }
        public int GetKnowledge()
        {
            return Level;
        }
    }
}
