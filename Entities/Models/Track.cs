using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Track
    {
        [Column("TrackId")]
        public Guid Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Artist { get; set; }
        public string? Bpm { get; set; }
        public string? Rating { get; set; }
        public string? Duration { get; set; }
        public DateTime? DateAdded { get; set; }

        [ForeignKey(nameof(User))]
        public string? UserId { get; set; }
        public User? UserAdded { get; set; }

        [ForeignKey(nameof(Genre))]
        public Guid GenreId { get; set; }
        public Genre? Genre { get; set; }

        [ForeignKey(nameof(Key))]
        public Guid KeyId { get; set; }
        public Key? Key { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
