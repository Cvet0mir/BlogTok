using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Services;

namespace BlogTok.Controllers
{
    public class ReactionController
    {
        private readonly ReactionService _service;

        public ReactionController()
        {
            _service = new();
        }

        public async Task<string> ReactToPostAsync(int userId, int postId, ReactionType type)
        {
            var existing = await _service.GetPostReactionAsync(userId, postId);

            if (existing != null)
            {
                await _service.RemovePostReactionAsync(existing);
                return "Reaction removed from post";
            }

            await _service.AddPostReactionAsync(new Reaction
            {
                UserId = userId,
                PostId = postId,
                Emotion = type
            });

            return "Reaction added to post";
        }

        public async Task<string> UnreactPostAsync(int userId, int postId)
        {
            var existing = await _service.GetPostReactionAsync(userId, postId);

            if (existing == null)
                return "No reaction to remove";

            await _service.RemovePostReactionAsync(existing);
            return "Reaction removed";
        }
    }
}