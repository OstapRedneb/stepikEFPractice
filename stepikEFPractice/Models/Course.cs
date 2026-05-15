using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stepikEFPractice.Models;

[Table("courses")]
public class Course
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(50)]
    [Column("title")]
    public string Title { get; set; }

    [Column("created_date")]
    public DateTime CreatedDate { get; set; }

    [Column("summary")]
    public string? Summary { get; set; }

    [Column("photo")]
    public string? Photo { get; set; }

    [Column("price", TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    public CertificateSetting CertificateSetting { get; set; }
    public List<Unit> Units { get; set; }
}
