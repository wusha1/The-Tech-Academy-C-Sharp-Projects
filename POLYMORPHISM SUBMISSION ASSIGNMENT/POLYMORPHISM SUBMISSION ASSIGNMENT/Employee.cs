public class Employee : IQuittable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Quit()
    {
        Console.WriteLine("Employee has quit the job.");
    }
}