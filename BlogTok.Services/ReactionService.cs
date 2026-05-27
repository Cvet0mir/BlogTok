using BlogTok.Data;
using BlogTok.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogTok.Services
{
    public class ReactionService
    {
        private readonly BlogTokDbContext _context;

        public ReactionService()
        {
            _context = new();
        }
        public ReactionService(BlogTokDbContext context)
        {
            _context = context;
        }

        public async Task<Reaction?> GetPostReactionAsync(int userId, int postId)
        {
            return await _context.Reactions
                .FirstOrDefaultAsync(r => r.UserId == userId && r.PostId == postId);
        }

        public async Task AddPostReactionAsync(Reaction reaction)
        {
            await _context.Reactions.AddAsync(reaction);
            await _context.SaveChangesAsync();
        }

        public async Task RemovePostReactionAsync(Reaction reaction)
        {
            _context.Reactions.Remove(reaction);
            await _context.SaveChangesAsync();
        }

        public async Task<CommentReaction?> GetCommentReactionAsync(int userId, int commentId)
        {
            return await _context.CommentReactions
                .FirstOrDefaultAsync(r => r.UserId == userId && r.CommentId == commentId);
        }

        public async Task AddCommentReactionAsync(CommentReaction reaction)
        {
            await _context.CommentReactions.AddAsync(reaction);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveCommentReactionAsync(CommentReaction reaction)
        {
            _context.CommentReactions.Remove(reaction);
            await _context.SaveChangesAsync();
        }
    }
}
