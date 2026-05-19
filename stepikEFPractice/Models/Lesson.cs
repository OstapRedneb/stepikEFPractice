using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stepikEFPractice.Models;

[Table("lessons")]
public class Lesson
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    public string? Title { get; set; }

    [Column("epic_count")]
    public int EpicCount { get; set; }

    [Column("abuse_count")]
    public int AbuseCount { get; set; }


    public List<Unit> Units { get; set; }
    public List<Step> Steps { get; set; }
}
