using System;

class Human;

public string Name 
public string Surname 
public string Gender 
private int age;

public int Age
{
    get { return age; }
    set
    {
        if (value >= 0)
        {
            age = value;
        }
        else
        {
            Console.WriteLine(" 0");
            age = 0;
        }
    }

    public Human(string name, string surname, string gender, int age)
{
    Name = name;
    Surname = surname;
    Gender = gender;
    Age = age;
}

public string GetInfo()
{
    return $"Name: {Name}, Surname: {Surname}, Gender: {Gender}, Age: {Age}";
}

public void ShowInfo()
{
    Console.WriteLine(GetInfo());
}