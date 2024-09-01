using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

[Table("Photos")]
public class Photo
{
    public int Id { get; set; }

    public required string Url { get; set; }

    public bool IsMain { get; set; }

    public string? PublicId { get; set; }

    // Navigation properties

    //We set nullable to false when running the migration in this way
    public int AppUserId { get; set; }

    public AppUser AppUser { get; set; } = null!;
}
