public class Job{
    // 4 attributes
    public string comp_name;
    public string job_title;
    public int start_yr;
    public int end_yr;

    // Create a constructor
    public Job(){}

    // 1 method
    public void display_job(){
        Console.WriteLine($"Job title: {job_title}  Company: {comp_name}  {start_yr}-{end_yr}");
        Console.WriteLine();
    }

}