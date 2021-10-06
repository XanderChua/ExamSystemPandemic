using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSystemPandemic
{
    class Student
    {
        public int studentID { get; private set; }
        public string studentName { get; private set; }
        public int Result { get; set; }
        public bool DoExamAlrAnot { get; set; }
        public Student(int id, string name, int result, bool finishexamalrd)
        {
            studentID = id;
            studentName = name;
            Result = result;
            DoExamAlrAnot = finishexamalrd;
        }
    }
}
