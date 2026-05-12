using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stepikEFPractice.Models;

[Table("users")]
public class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("full_name")]
    public string FullName { get; set; }

    [Column("details")]
    public string? Details { get; set; }

    [Column("join_date")]
    public DateTime JoinDate { get; set; }

    [Column("avatar")]
    public string? Avatar { get; set; }

    [Column("is_active")]
    public bool IsActive { get; set; }

    [Column("knowledge")]
    public int Knowledge { get; set; } = 0;

    [Column("reputation")]
    public int Reputation { get; set; } = 0;

    [Column("folowers_count")]
    public int FollowersCount { get; set; } = 0;

    [Column("days_without_break")]
    public int DaysWithoutBreak { get; set; } = 0;

    [Column("days_without_break_max")]
    public int DaysWithoutBreakMax { get; set; } = 0;

    [Column("solved_tasks")]
    public int SolvedTasks { get; set; } = 0;


    public User() : this("Vitalik")
    { }
    public User(string name)
    {
        FullName = name;
        JoinDate = DateTime.Now;
        IsActive = true;
    }
}
