using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Comment
    {
        [Column("ColumnId")]
        public Guid Id { get; set; }
        [Required]
        public string? CommentText { get; set; }

        [ForeignKey(nameof(Track))]
        public Guid TrackId { get; set; }
        public Track? Track { get; set; }
        
    }
}
