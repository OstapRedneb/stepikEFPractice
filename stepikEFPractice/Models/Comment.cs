using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stepikEFPractice.Models;

[Table("comments")]
public class Comment
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("step_id")]
    public int? StepId { get; set; }

    [ForeignKey(nameof(Comment))]
    [Column("reply_comment_id")]
    public int? ReplyCommentId { get; set; }

    [ForeignKey(nameof(User))]
    [Column("user_id")]
    public int UserId { get; set; }

    [Column("time")]
    public DateTime Time { get; set; }

    [Column("text")]
    public string Text { get; set; }

    [Column("epic_count")]
    public int EpicCount { get; set; }

    [Column("abuse_count")]
    public int AbuseCount { get; set; }


    public List<Comment> ReplyComments { get; set; }
    public Comment ReplyComment { get; set; }
    public User User { get; set; }
    public CourseReview CourseReview { get; set; }
}
