namespace Learning02;

using Job;
using Resume;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Ryan LLC";
        job1._startYear = 2020;
        job1._endYear = 2055;

        Job job2 = new Job();
        job2._jobTitle = "Mechanical Engineer";
        job2._company = "Project E";
        job2._startYear = 2025;
        job2._endYear = 2029;

        Resume resume1 = new Resume();
        resume1._name = "Ethan Jameson";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);    
        
        resume1.DisplayR();
    }
}