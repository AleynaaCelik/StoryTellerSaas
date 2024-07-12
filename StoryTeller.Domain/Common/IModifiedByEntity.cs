using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Domain.Common
{
    public class IModifiedByEntity
    {
        DateTimeOffset? ModifiedOn { get; set; }
        string? ModifiedByUserId { get; set; }
    }
}
