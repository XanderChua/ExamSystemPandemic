using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSystemPandemic
{
    class StudentManagement
    {
        private Dictionary<string, Student> _studentdict;
        public Dictionary<string, Student> StudentDictObj
        {
            get
            {
                if (_studentdict == null)
                {
                    _studentdict = new Dictionary<string, Student>();
                }
                return _studentdict;
            }
            private set
            {
                _studentdict = value;
            }
        }

        public Student this[string studentName]
        {
            get { return StudentDictObj[studentName]; }
            private set { StudentDictObj[studentName] = value; }
        }
    }
}
