using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Services;

namespace BlogTok.Controllers
{
    public class CommentReactionController
    {
        private readonly ReactionService _service;

        public CommentReactionController()
        {
            _service = new();
        }

        public async Task<string> ReactToCommentAsync(int userId, int commentId, ReactionType type)
        {
            var existing = await _service.GetCommentReactionAsync(userId, commentId);
            if (existing != null)
            {
                await _service.RemoveCommentReactionAsync(existing);
                return "Reaction removed from comment";
            }

            await _service.AddCommentReactionAsync(new CommentReaction
            {
                UserId = userId,
                CommentId = commentId,
                Emotion = type
            });
            return "Reaction added to comment";
        }

        public async Task<string> UnreactCommentAsync(int userId, int commentId)
        {
            var existing = await _service.GetCommentReactionAsync(userId, commentId);
            if (existing == null) return "No reaction to remove";

            await _service.RemoveCommentReactionAsync(existing);
            return "Reaction removed";
        }
    }
}
