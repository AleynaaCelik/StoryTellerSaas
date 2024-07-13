using StoryTeller.Application.Features.Orders.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Application.Common.Models.OpenAI
{
    public class DallECreateStoryDto
    {

        public string Title { get; set; }
        public List<string> Characters { get; set; }
        public List<string> Locations { get; set; }
        public List<string> Events { get; set; }
        public string Genre { get; set; } // Hikaye türü (masal, bilim kurgu, vb.)
        public int Length { get; set; } // Hikayenin uzunluğu (kelime sayısı)

        public DallECreateStoryDto()
        {
            Characters = new List<string>();
            Locations = new List<string>();
            Events = new List<string>();
        }

        public static DallECreateStoryDto MapFromStoryAddCommand(StoryAddCommand storyAddCommand)
        {
            return new DallECreateStoryDto
            {
                Title = storyAddCommand.Title,
                Characters = storyAddCommand.Characters,
                Locations = storyAddCommand.Locations,
                Events = storyAddCommand.Events,
                Genre = storyAddCommand.Genre,
                Length = storyAddCommand.Length
            };
        }
    }
}
