using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace stepikEFPractice.Models
{
    [Table("units")]
    public class Unit
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey(nameof(Course))]
        [Column("course_id")]
        public int CourseId { get; set; }

        [Column("title")]
        public string? Title { get; set; }

        public Course Course { get; set; }

        public List<Lesson> Lessons { get; set; }
    }
}
