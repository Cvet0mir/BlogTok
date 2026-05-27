using BlogTok.Data;
using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogTok.Services
{
    public class UserService
    {
        private readonly BlogTokDbContext _context;

        public UserService()
        {
            _context = new();
        }
        public UserService(BlogTokDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> SearchAsync(string text)
        {
            return await _context.Users
                .Where(u => u.FirstName.Contains(text) ||
                            u.Surname.Contains(text))
                .ToListAsync();
        }

        public async Task<List<User>> GetFollowersAsync(int userId)
        {
            return await _context.UserFollows
                .Where(f => f.FollowingId == userId)
                .Select(f => f.Follower)
                .ToListAsync();
        }

        public async Task<List<User>> GetFollowingAsync(int userId)
        {
            return await _context.UserFollows
                .Where(f => f.FollowerId == userId)
                .Select(f => f.Following)
                .ToListAsync();
        }

        public async Task FollowAsync(int followerId, int followingId)
        {
            await _context.UserFollows.AddAsync(new UserFollow
            {
                FollowerId = followerId,
                FollowingId = followingId
            });

            await _context.SaveChangesAsync();
        }

        public async Task UnfollowAsync(int followerId, int followingId)
        {
            var follow = await _context.UserFollows
                .FirstOrDefaultAsync(f =>
                    f.FollowerId == followerId &&
                    f.FollowingId == followingId);

            if (follow != null)
            {
                _context.UserFollows.Remove(follow);
                await _context.SaveChangesAsync();
            }
        }
    }
}