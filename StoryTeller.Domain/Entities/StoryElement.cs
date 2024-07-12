using StoryTeller.Domain.Common;
using StoryTeller.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Domain.Entities
{
    public class StoryElement : EntityBase
    {
        public StoryElementType Type { get; set; }

        [Required]
        public string Description { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Story> Stories { get; set; }
    }
}
