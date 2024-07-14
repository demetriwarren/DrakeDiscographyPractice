using System.ComponentModel.DataAnnotations;

namespace DrakeDiscographyPractice.Models
{
    public class Song
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Artist { get; set; } = string.Empty;

        public int Disc { get; set; } = 1;

        [StringLength(50)]
        public string TrackName { get; set; } = string.Empty;

        public int TrackNumber { get; set; }

        [StringLength(50)]
        public string? Feature { get; set; } = string.Empty;

        [StringLength(50)]
        public string? Description { get; set; } = string.Empty;

        [StringLength(255)]
        public string? PhotoPath { get; set; } = string.Empty;

        public TimeOnly Duration { get; set; } = new TimeOnly(0, 0, 0);

        public bool Single { get; set; } = false;

        public virtual Album? Album {get; set;}
        
    }
}
