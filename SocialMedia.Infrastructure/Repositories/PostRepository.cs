using System;
using System.Linq;
using System.Collections.Generic;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            var posts = Enumerable.Range(1,10).Select(x => new Post
            {
                PostId = x,
                UserId = x * 2,
                Date = DateTime.Now,
                Description = $"Description {x}",
                Image = $"https://misapis.com/{x}"
            });

            return posts;
        }
    }
}