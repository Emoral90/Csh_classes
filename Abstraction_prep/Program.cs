/************************************************
*
*   Practice creating and using classes in C#
*
*************************************************/
public class Job{
    public string comp_name;
    public string job_title;
    public int start_yr;
    public int end_yr;

    public Job(){
        // Job job = new Job();
    }

    public void display_job(){
        Console.WriteLine($"Job title: {job_title}  Company: {comp_name}  {start_yr}-{end_yr}");
        Console.WriteLine();
    }
    static void Main(){
        Job job1 = new Job();
        Job job2 = new Job();
        
        job1.comp_name = "Honda";
        job1.job_title = "Lead ECU Engineer";
        job1.start_yr = 2020;
        job1.end_yr = 2022;

        job2.comp_name = "Vista High School";
        job2.job_title = "CNS Student Assistant";
        job2.start_yr = 2012;
        job2.end_yr = 2016;

        job1.display_job();
        job2.display_job();
    }

}