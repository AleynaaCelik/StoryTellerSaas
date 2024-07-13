using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Application.Features.Orders.Commands.Add
{
    public class StoryAddCommand
    {
        public string Title { get; set; }
        public List<string> Characters { get; set; }
        public List<string> Locations { get; set; }
        public List<string> Events { get; set; }
        public string Genre { get; set; }
        public int Length { get; set; }

        public StoryAddCommand()
        {
            Characters = new List<string>();
            Locations = new List<string>();
            Events = new List<string>();
        }
    }
}
