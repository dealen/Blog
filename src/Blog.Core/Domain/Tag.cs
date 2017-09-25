using System;

namespace Blog.Core.Domain
{
    public class Tag
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }

        protected Tag(){}

        protected Tag(string name)
        {
            Name = name;
        }
    }
}