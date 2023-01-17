/************************************************
*
*   Practice creating and using classes in C#
*
*************************************************/

public class Resume{
    public string name;
    public List<string> jobs;

    public void display_resume(){
        Console.WriteLine($"Name: {name}  Jobs: {jobs}");
    }

}