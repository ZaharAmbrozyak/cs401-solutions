namespace practice_4;

public class Course : IInformable
{
    private int id;
    private string name;
    private string teacher;

    public void GetInfo()
    {
        Console.WriteLine($"id {id}: course name - {name}, teacher name - {teacher}");
    }
}
