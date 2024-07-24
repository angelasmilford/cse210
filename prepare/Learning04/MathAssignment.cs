namespace library_demo
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        //stores the student's name, the topic, the textbook section, and the problems from that section
        //"Ian", "Fractions", "7.3", "3-10", "20-21"

        public MathAssignment(string studentName, string topic, string textbookSetion, string problems) : base (studentName, topic)
        {
            _textbookSection = textbookSetion;
            _problems = problems;
        }

        public string GetHomeworkList() //displays homework list.
        {
            
            return $"Section {_textbookSection} Problems {_problems}";
        }
    }
}