using System;

namespace stepikEFPractice.Models;

public class User
{
    public int Id {get; set;}
    public string Full_Name {get; set;}
    public string? Details {get; set;}
    public DateTime Join_Date {get;set;}
    public string? Avatar {get; set;}
    public bool Is_Active {get; set;}
    public int Knowledge {get; set;} = 0;
    public int Reputation {get; set;} = 0;
    public int Followers_Count {get; set;} = 0;
    public int Days_Without_Break {get; set;} = 0;
    public int DaysWithoutBreakMax {get; set;} = 0;
    public int Solved_Tasks {get; set;} = 0;

    public User() : this("Vitalik")
    {}
    public User(string name)
    {
        Full_Name = name;
        Join_Date = DateTime.Now;
        Is_Active = true;
    }
}
