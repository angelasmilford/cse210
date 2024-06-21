using System;

class Program
{
    static void Main(string[] args)
    {
        
        //instance 
        Job job1 = new Job();
        job1._company = "Bluesky";
        job1._jobTitle = "Products Manager";
        job1._startYear = 2006;
        job1._endYear = 2027;
        job1.Display();

        Job job2 = new Job();
        job2._company = "ASPA";
        job2._jobTitle = "Water Engineer";
        job2._startYear = 2004;
        job2._endYear = 2027;
        job2.Display();

        Job job3 = new Job();
        job3._company = "ASDOE";
        job3._jobTitle = "ECE Teacher";
        job3._startYear = 2001;
        job3._endYear = 2015;
        job3.Display();

        Resume resume1 = new Resume();
        resume1._name = "Berlinda";
        resume1._jobs.Add(job1);
        resume1.Display();

        Resume resume2 = new Resume();
        resume2._name = "Andre";
        resume2._jobs.Add(job2);
        resume2.Display();

        Resume resume3 = new Resume();
        resume3._name = "Suria";
        resume3._jobs.Add(job3);
        resume3.Display();
    }
}