namespace task3;

abstract public class Animal
{
 string _Name;

 public void SetName(string name){
    _Name = name;
 }
 public string GetName(){
    return _Name;
 }  
abstract public void Eat();

public void DogName()
{
    System.Console.WriteLine($"{_Name}");
}
}
