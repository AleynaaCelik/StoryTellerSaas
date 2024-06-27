using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Domain.Entities
{
    public class StoryElement
    {
        public int Id { get; set; }
        public StoryElementType Type { get; set; } // Enum kullanarak tipi belirliyoruz
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
