using BlogTok.Data;
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
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Post>> GetUserPostsAsync(int userId)
        {
            return await _context.Posts
                .Where(p => p.UserId == userId)
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync();
        }

        public async Task<List<Post>> GetFeedAsync(List<int> userIds)
        {
            return await _context.Posts
                .Where(p => userIds.Contains(p.UserId))
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync();
        }
    }
}