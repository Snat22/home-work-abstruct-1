namespace task1;

public class Student :Person
{
    public Student(string name) : base(name)
    {
    }

    public override void PersonInfo()
    {
        System.Console.WriteLine($"The student is studying");
    }
    // public Student(string name) 
    // {
        
    // }
}
