/************************************************
*
*   Practice creating and using classes in C#
*
*************************************************/
public class Job{
    public string comp_name = "Ibishu";
    public string job_title = "Lead System Architect";
    public int start_yr = 2010;
    public int end_yr = 2020;

    public Job(){
        // Job job = new Job();
    }

    public void display_job(){
        Console.WriteLine($"Job title: {job_title}  Company: {comp_name}  {start_yr}-{end_yr}");
    }
    static void Main(){
        Job job = new Job();
        
        job.display_job();
    }

}