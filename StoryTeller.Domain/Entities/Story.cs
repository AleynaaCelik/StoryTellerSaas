using StoryTeller.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Domain.Entities
{
    public class Story : EntityBase
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<StoryElement> StoryElements { get; set; }
    }
}
