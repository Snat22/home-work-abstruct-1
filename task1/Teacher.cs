namespace task1;

public class Teacher : Person
{
    
    public Teacher(string name) : base(name)
    {
    }

    public override void PersonInfo()
    {
        System.Console.WriteLine("The teacher is explaining");
    }
}
