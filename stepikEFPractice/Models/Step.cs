using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stepikEFPractice.Models;

[Table("steps")]
public class Step
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [ForeignKey(nameof(Lesson))]
    [Column("lesson_id")]
    public int LessonId { get; set; }


    [Column("position")]
    public int Position { get; set; }


    [Column("title")]
    public string? Title { get; set; }


    [Column("content")]
    public string? Content { get; set; }


    [Column("cost")]
    public int Cost { get; set; }


    public Lesson Lesson { get; set; }
}
