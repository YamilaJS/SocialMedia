using System;
using System.Linq;
using System.Collections.Generic;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = Enumerable.Range(1,10).Select(x => new Post
            {
                PostId = x,
                UserId = x * 2,
                Date = DateTime.Now,
                Description = $"Description {x}",
                Image = $"https://misapis.com/{x}"
            });
            await Task.Delay(10);
            return posts;
        }
    }
}