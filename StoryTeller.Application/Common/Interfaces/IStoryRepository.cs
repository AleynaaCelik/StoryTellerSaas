using StoryTeller.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Application.Common.Interfaces
{
    public interface IStoryRepository
    {
        Task<bool> AddAsync(Story story);
    }
}
