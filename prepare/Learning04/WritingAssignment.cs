using System.Reflection;

namespace library_demo
{
    public class WritingAssignment : Assignment
    {
        private string _title;

        //stores student's name, the topic, and the title of the assignment
        //"Angela", "Pacific History", "Samoan Civil War"
        
        public WritingAssignment(string studentName, string topic, string title) : base (studentName, topic)
        {
            _title = title;
        }

        public string GetWritingInformation() //gets writing information
        {
            string studentName = GetStudentName();
            return $"{_title} by {studentName}";
        }
    }
}