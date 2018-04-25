using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeMachine.Domain
{
    public class Post
    {
        public int Id { get; set; }

        public int FromId { get; set; }

        public int OwnerId { get; set; }

        public DateTime Date { get; set; }

        public string PostType { get; set; }

        public bool CommentCanPost { get; set; }
    }
}
