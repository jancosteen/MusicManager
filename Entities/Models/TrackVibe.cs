using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class TrackVibe
    {
        [Column("TrackVibeId")]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Track))]
        public Guid TrackId { get; set; }
        public Track? Track { get; set; }

        [ForeignKey(nameof(Vibe))]
        public Guid VibeId { get; set; }
        public Vibe? Vibe { get; set; }

    }
}
