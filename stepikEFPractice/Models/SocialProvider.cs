using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace stepikEFPractice.Models;

[Table("social_providers")]
public class SocialProvider
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("logo_url")]
    public string LogoUrl { get; set; }

    public List<UserSocialProvider> UserSocialProviders { get; set; }
}
