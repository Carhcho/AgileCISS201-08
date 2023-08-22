using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesar Roncancio
//CISS201
//Agile Development
//10/4/2020
namespace dropbox08
{
    class CollegeStudent
    {
        //fields
        private string studentName;
        private int midTerm1;
        private int midTerm2;
        private int finalExam;
        //properties
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int MidTerm1
        {
            get { return midTerm1; }
            set { midTerm1 = value; }
        }
        public int MidTerm2
        {
            get { return midTerm2; }
            set { midTerm2 = value; }
        }
        public int FinalExam
        {
            get { return finalExam; }
            set { finalExam = value; }
        }
        //constructors
        public CollegeStudent(string studentName, int midTerm1, int midTerm2, int finalExam)
        {
            this.studentName = studentName;
            this.midTerm1 = midTerm1;
            this.midTerm2 = midTerm2;
            this.finalExam = finalExam;
        }
        //methods
        public double CalculateSemesterGrade()
        {
            double studentScore = 0;
            studentScore = MidTerm1 * 0.3 + MidTerm2 * 0.3 + FinalExam * 0.4;
            return studentScore;
        }
        public override string ToString()
        {
            string str;
            str = string.Format("Name: {0}   Grade: {1}", StudentName, CalculateSemesterGrade());
            return str;
        }
    }
}
