using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Services;

namespace BlogTok.Controllers
{
    public class PostController
    {
        private readonly PostService _postService;
        private readonly UserService _userService;

        public PostController(PostService postService, UserService userService)
        {
            _postService = postService;
            _userService = userService;
        }

        public async Task<string> CreatePostAsync(
            int userId,
            string title,
            string? description,
            string? picture)
        {
            if (string.IsNullOrWhiteSpace(title)) return "Title is required";
            if (title.Length > 100) return "Title too long";

            var post = new Post
            {
                UserId = userId,
                Title = title,
                Description = description,
                Picture = picture,
                CreatedAt = DateTime.Now
            };

            await _postService.AddAsync(post);

            return "Post created successfully";
        }

        public async Task<string> DeletePostAsync(int userId, int postId)
        {
            var post = await _postService.GetByIdAsync(postId);

            if (post == null)
                return "Post not found";

            if (post.UserId != userId)
                return "You can only delete your own posts";

            await _postService.DeleteAsync(post);

            return "Post deleted";
        }

        public Task<List<Post>> GetUserPostsAsync(int userId)
        {
            return _postService.GetUserPostsAsync(userId);
        }

        public async Task<List<Post>> GetFeedAsync(int userId)
        {
            var following = await _userService.GetFollowingAsync(userId);

            var ids = following.Select(u => u.Id).ToList();
            ids.Add(userId);

            return await _postService.GetFeedAsync(ids);
        }

        public Task<Post?> GetPostAsync(int postId)
        {
            return _postService.GetByIdAsync(postId);
        }
    }
}