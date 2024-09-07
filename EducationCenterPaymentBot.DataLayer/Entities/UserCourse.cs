using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationCenterPaymentBot.DataLayer;

[Table("user_course")]
public partial class UserCourse
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("course_id")]
    public int CourseId { get; set; }

    [Column("state_id")]
    public int StateId { get; set; }

    [Column("is_teacher")]
    public bool? IsTeacher { get; set; }

    [Column("created_date", TypeName = "timestamp without time zone")]
    public DateTime CreatedDate { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("UserCourses")]
    public virtual Course Course { get; set; } = null!;

    [ForeignKey("StateId")]
    [InverseProperty("UserCourses")]
    public virtual State State { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserCourses")]
    public virtual SysUser User { get; set; } = null!;
}
