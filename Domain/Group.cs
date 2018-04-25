using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeMachine.Domain
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ScreenName { get; set; }

        public bool CanPost { get; set; }

        public bool CanCreateTopic { get; set; }

        public int? FixedPost { get; set; }
    }
}
