
// Make a driver class
public class Program{

    // Main() function to serve as entry point for dotnet
    static void Main(){
        // Create 2 instances of the Job class
        Job job1 = new Job();
        Job job2 = new Job();
        
        // Assign variables to job1 instance
        job1.comp_name = "Honda";
        job1.job_title = "Lead ECU Engineer";
        job1.start_yr = 2020;
        job1.end_yr = 2022;

        // Assign variables to job2 instance
        job2.comp_name = "Vista High School";
        job2.job_title = "CNS Student Assistant";
        job2.start_yr = 2012;
        job2.end_yr = 2016;

        // call the display method for both instances
        job1.display_job();
        job2.display_job();
    }

}