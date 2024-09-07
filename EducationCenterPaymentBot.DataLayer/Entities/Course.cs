using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationCenterPaymentBot.DataLayer;

[Table("course")]
public partial class Course
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("code")]
    [StringLength(10)]
    public string? Code { get; set; }

    [Column("short_name")]
    [StringLength(50)]
    public string ShortName { get; set; } = null!;

    [Column("full_name")]
    [StringLength(50)]
    public string FullName { get; set; } = null!;

    [Column("state_id")]
    public int StateId { get; set; }

    [Column("organization_id")]
    public int OrganizationId { get; set; }

    [Column("created_date", TypeName = "timestamp without time zone")]
    public DateTime CreatedDate { get; set; }

    [ForeignKey("OrganizationId")]
    [InverseProperty("Courses")]
    public virtual Organization Organization { get; set; } = null!;

    [ForeignKey("StateId")]
    [InverseProperty("Courses")]
    public virtual State State { get; set; } = null!;

    [InverseProperty("Course")]
    public virtual ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
}
