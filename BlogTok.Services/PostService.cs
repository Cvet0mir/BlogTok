using BlogTok.Data;
using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogTok.Services
{
    public class PostService
    {
        private readonly BlogTokDbContext _context;

        public PostService()
        {
            _context = new();
        }
        public PostService(BlogTokDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Post post)
        {
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Post post)
        {
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
        }

        public async Task<Post?> GetByIdAsync(int id)
        {
            return await _context.Posts
                .Include(p => p.Comments)
                .Include(p => p.Reactions)
                .Include(x => x.User)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Post>> GetUserPostsAsync(int userId)
        {
            return await _context.Posts
                .Include(x => x.User)
                .Include(p => p.Reactions)
                .Where(p => p.UserId == userId)
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync();
        }

        public async Task<List<Post>> GetFeedAsync()
        {
            return await _context.Posts
                .Include(x => x.User)
                .Include(p => p.Reactions)
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync();
        }
        public async Task<List<Post>> GetMostLikedPostsAsync(int count = 20)
        {
            return await _context.Posts
                .Include(x => x.User)
                .Include(p => p.Reactions)
                .Select(p => new
                {
                    Post = p,
                    LikeCount = p.Reactions.Count(r => r.Emotion == ReactionType.Like)
                })
                .OrderByDescending(x => x.LikeCount)
                .ThenByDescending(x => x.Post.CreatedAt)
                .Take(count)
                .Select(x => x.Post)
                .ToListAsync();
        }
    }
}
// za proverqvashtiq: hiii 😁
