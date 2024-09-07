using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationCenterPaymentBot.DataLayer;

[Table("state")]
public partial class State
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("code")]
    [StringLength(50)]
    public string? Code { get; set; }

    [Column("short_name")]
    [StringLength(250)]
    public string ShortName { get; set; } = null!;

    [Column("full_name")]
    [StringLength(250)]
    public string FullName { get; set; } = null!;

    [Column("created_date", TypeName = "timestamp without time zone")]
    public DateTime CreatedDate { get; set; }

    [InverseProperty("State")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [InverseProperty("State")]
    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();

    [InverseProperty("State")]
    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    [InverseProperty("State")]
    public virtual ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
}
