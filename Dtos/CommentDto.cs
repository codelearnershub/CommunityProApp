using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Dtos
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public string ProductComment { get; set; }
    }
}
