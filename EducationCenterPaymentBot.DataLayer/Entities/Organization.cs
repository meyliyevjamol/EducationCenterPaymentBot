using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationCenterPaymentBot.DataLayer;

[Table("organization")]
public partial class Organization
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("order_code")]
    [StringLength(50)]
    public string? OrderCode { get; set; }

    [Column("short_name")]
    [StringLength(250)]
    public string ShortName { get; set; } = null!;

    [Column("full_name")]
    [StringLength(300)]
    public string FullName { get; set; } = null!;

    [Column("inn")]
    [StringLength(9)]
    public string? Inn { get; set; }

    [Column("state_id")]
    public int StateId { get; set; }

    [Column("created_date", TypeName = "timestamp without time zone")]
    public DateTime CreatedDate { get; set; }

    [InverseProperty("Organization")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [ForeignKey("StateId")]
    [InverseProperty("Organizations")]
    public virtual State State { get; set; } = null!;

    [InverseProperty("Organization")]
    public virtual ICollection<SysUser> SysUsers { get; set; } = new List<SysUser>();
}
