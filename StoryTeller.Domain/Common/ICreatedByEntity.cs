using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Domain.Common
{
    public interface ICreatedByEntity
    {
        DateTimeOffset CreatedOn { get; set; }//8 (UTC+8) Datetime göre daha geniş zaman dilimi tuttar
        string CreatedByUserId { get; set; }
    }
}
