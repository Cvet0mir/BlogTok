using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Services;

namespace BlogTok.Controllers
{
    public class CommentController
    {
        private readonly CommentService _service;
        private readonly UserService _userService;

        public CommentController()
        {
            _service = new();
            _userService = new();
        }

        public async Task<string> CreateCommentAsync(int userId, int postId, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return "Comment cannot be empty";

            if (content.Length > 250)
                return "Comment too long (max 250 characters)";

            var comment = new Comment
            {
                UserId = userId,
                PostId = postId,
                Content = content
            };

            await _service.AddAsync(comment);
            return "Comment added";
        }

        public async Task<string> EditCommentAsync(int userId, int commentId, string newContent)
        {
            if (string.IsNullOrWhiteSpace(newContent)) return "Comment cannot be empty";

            var comment = await _service.GetByIdAsync(commentId);
            if (comment == null) return "Comment not found";

            if (comment.UserId != userId) return "You can only edit your own comments";

            comment.Content = newContent;
            await _service.UpdateAsync(comment);
            return "Comment updated";
        }

        public async Task<string> DeleteCommentAsync(int userId, int commentId)
        {
            var comment = await _service.GetByIdAsync(commentId);
            if (comment == null) return "Comment not found";
            if (comment.UserId != userId) return "You can only delete your own comments";

            await _service.DeleteAsync(comment);
            return "Comment deleted";
        }

        public Task<List<Comment>> GetCommentsForPostAsync(int postId)
        {
            return _service.GetByPostIdAsync(postId);
        }
    }
}