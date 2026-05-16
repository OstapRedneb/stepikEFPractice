using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace stepikEFPractice.Models;

[Table("certificates")]
[PrimaryKey(nameof(UserId), nameof(CourseId))]
public class Certificate
{
    [ForeignKey(nameof(User))]
    [Column("user_id")]
    public int UserId { get; set; }

    [ForeignKey(nameof(Course))]
    [Column("course_id")]
    public int CourseId { get; set; }

    [Column("grade")]
    public int Grade { get; set; }

    [Column("issue_date")]
    public DateTime IssueDate { get; set; }

    [Column("url")]
    public string Url { get; set; }

    public User User { get; set; }
    public Course Course { get; set; }
}
