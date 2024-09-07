using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationCenterPaymentBot.DataLayer;

[Table("sys_user")]
public partial class SysUser
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("short_name")]
    [StringLength(100)]
    public string? ShortName { get; set; }

    [Column("chat_id")]
    public long ChatId { get; set; }

    [Column("phone_number")]
    [StringLength(50)]
    public string? PhoneNumber { get; set; }

    [Column("organization_id")]
    public int OrganizationId { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("created_date", TypeName = "timestamp without time zone")]
    public DateTime CreatedDate { get; set; }

    [ForeignKey("OrganizationId")]
    [InverseProperty("SysUsers")]
    public virtual Organization Organization { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("SysUsers")]
    public virtual Role? Role { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
}
