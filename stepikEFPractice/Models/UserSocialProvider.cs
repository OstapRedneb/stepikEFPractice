using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace stepikEFPractice.Models;

[Table("user_social_providers")]
[PrimaryKey(nameof(UserId), nameof(SocialProviderId))]
public class UserSocialProvider
{
    [ForeignKey(nameof(User))]
    [Column("user_id")]
    public int UserId { get; set; }

    [ForeignKey(nameof(SocialProvider))]
    [Column("social_provider_id")]
    public int SocialProviderId { get; set; }

    [Column("connect_url")]
    public string ConnectUrl { get; set; }

    public User User {get; set;}
    public SocialProvider SocialProvider {get; set;}
}
