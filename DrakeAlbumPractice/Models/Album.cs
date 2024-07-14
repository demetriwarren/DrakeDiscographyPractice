using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrakeDiscographyPractice.Models
{
    public class Album
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string AlbumName { get; set; } = string.Empty;

        public int? Disc {  get; set; } = 1;
        
        [StringLength(255)]
        public string? Description { get; set; } = string.Empty;
        
        public int TrackCount { get; set; } = 0;

        [StringLength(255)]
        public string? PhotoPath {  get; set; } = string.Empty;
        
        public TimeOnly Duration { get; set; } = new TimeOnly(0,0,0);

        public DateTime ReleaseDate { get; set; } = new DateTime(1999,01,01);

        public virtual Artist Artist { get; set; } 
    }
}
