using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Application.Features.Orders.Commands.Add
{
    public class StoryAddCommandValidator : AbstractValidator<StoryAddCommand>
    {
        public StoryAddCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(100).WithMessage("Title must not exceed 100 characters.");

            RuleFor(x => x.Characters)
                .NotEmpty().WithMessage("At least one character is required.");

            RuleFor(x => x.Locations)
                .NotEmpty().WithMessage("At least one location is required.");

            RuleFor(x => x.Events)
                .NotEmpty().WithMessage("At least one event is required.");

            RuleFor(x => x.Genre)
                .NotEmpty().WithMessage("Genre is required.");

            RuleFor(x => x.Length)
                .GreaterThan(0).WithMessage("Length must be greater than 0.");
        }
    }
}

