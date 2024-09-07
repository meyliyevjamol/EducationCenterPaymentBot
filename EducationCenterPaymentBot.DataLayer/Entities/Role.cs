using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationCenterPaymentBot.DataLayer;

[Table("role")]
public partial class Role
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    public string? Code { get; set; }

    [Column("short_name")]
    [StringLength(250)]
    public string ShortName { get; set; } = null!;

    [Column("full_name")]
    [StringLength(300)]
    public string FullName { get; set; } = null!;

    [Column("is_admin")]
    public bool IsAdmin { get; set; }

    [Column("state_id")]
    public int StateId { get; set; }

    [Column("created_date", TypeName = "timestamp without time zone")]
    public DateTime CreatedDate { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("Roles")]
    public virtual State State { get; set; } = null!;

    [InverseProperty("Role")]
    public virtual ICollection<SysUser> SysUsers { get; set; } = new List<SysUser>();
}
