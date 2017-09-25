using System;

namespace Blog.Core.Domain
{
    public class Comment
    {
        public Guid Id { get; protected set; }
        public string Title { get; protected set; }
        public string Content { get; protected set; }
        public Guid? AuthorId { get; protected set; }
        public string AuthorName { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        protected Comment(){}

        public Comment(Guid id, string title, string content, Guid? authorId, string authorName)
        {
            Id = id;
            Title = title;
            Content = content;
            AuthorId = authorId;
            AuthorName = authorName;
            CreatedAt = DateTime.UtcNow;
        }
    }
}