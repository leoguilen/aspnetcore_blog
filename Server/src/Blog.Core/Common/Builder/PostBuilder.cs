﻿using Medium.Core.Domain;
using System;

namespace Medium.Core.Common.Builder
{
    public class PostBuilder
    {
        private readonly Post _post;

        public PostBuilder()
        {
            _post = new Post();
        }

        public PostBuilder WithId(Guid id)
        {
            _post.Id = id;
            return this;
        }

        public PostBuilder WithTitle(string title)
        {
            _post.Title = title;
            return this;
        }

        public PostBuilder WithContent(string content)
        {
            _post.Content = content;
            return this;
        }

        public PostBuilder WithAttachments(string atts)
        {
            _post.Attachments = atts;
            return this;
        }

        public PostBuilder WithAuthor(Guid authorId)
        {
            _post.AuthorId = authorId;
            return this;
        }

        public Post Build()
        {
            return _post;
        }
    }
}
