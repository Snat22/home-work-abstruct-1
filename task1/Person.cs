namespace task1;

public class Person
{
 string _Name ;

 public Person(string name)
 {
    _Name = name;
 }
 public virtual void PersonInfo()
 {
    System.Console.WriteLine(ToString());
 }

}
