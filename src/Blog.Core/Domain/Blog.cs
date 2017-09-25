using System;
using System.Collections.Generic;

namespace Blog.Core.Domain
{
    public class Blog
    {
        public Guid Id { get; protected set; }
        public string BlogName { get; protected set; }
        public IEnumerable<Post> Posts { get; protected set; }
    }
}