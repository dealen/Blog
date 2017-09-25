using System;
using System.Collections.Generic;

namespace Blog.Core.Domain
{
    public class Post
    {
        public Guid Id { get; protected set; }
        public string Title { get; protected set; }
        public Guid AuthorId { get; protected set; }
        public string Content { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        public IEnumerable<Tag> Tags { get; protected set; }
        public IEnumerable<Comment> Comments { get; protected set; }

        public Post(){}

        public Post(Guid id, string title, Guid authorId, string content)
        {
            Id = id;
            Title = title;
            AuthorId = authorId;
            Content = content;
            CreatedAt = DateTime.UtcNow;
        }

        public void AddComment()
        {

        }

        public void DeleteComment()
        {
            
        }
    }
}