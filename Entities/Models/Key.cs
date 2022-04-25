using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Key
    {
        [Column("KeyId")]
        public Guid Id { get; set; }
        [Required]
        public string? Value { get; set; }
        public ICollection<Track>? Tracks { get; set; }
    }
}
