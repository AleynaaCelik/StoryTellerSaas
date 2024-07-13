using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace StoryTeller.Application.Features.Orders.Commands.Add
{
    public class StoryAddCommandHandler : IRequestHandler<StoryAddCommand, bool>
    {
        // Assuming you have a StoryRepository to handle data operations
        private readonly IStoryRepository _storyRepository;

        public StoryAddCommandHandler(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }

        public async Task<bool> Handle(StoryAddCommand request, CancellationToken cancellationToken)
        {
            // Map the request to the Story entity
            var story = new Story
            {
                Title = request.Title,
                Characters = request.Characters,
                Locations = request.Locations,
                Events = request.Events,
                Genre = request.Genre,
                Length = request.Length
            };

            // Add the story to the repository
            var result = await _storyRepository.AddAsync(story);

            return result;
        }
    }

    // Assuming you have a Story entity and an IStoryRepository interface
    public class Story
    {
        public string Title { get; set; }
        public List<string> Characters { get; set; }
        public List<string> Locations { get; set; }
        public List<string> Events { get; set; }
        public string Genre { get; set; }
        public int Length { get; set; }
    }

    public interface IStoryRepository
    {
        Task<bool> AddAsync(Story story);
    }
}
