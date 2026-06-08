using BlogTok.Data;
using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace BlogTok.Controllers
{
    public class UserController
    {
        private readonly UserService _service;

        public UserController()
        {
            _service = new();
        }
        public UserController(BlogTokDbContext context)
        {
            _service = new(context);
        }

        public async Task<string> RegisterAsync(string email, string password, string firstName, string surname, DateTime birthDate, string imgPath)
        {
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(surname))
                return "All fields are required";

            if (password.Length < 6) return "Password must be at least 6 characters";

            var existing = await _service.GetByEmailAsync(email);
            if (existing != null) return "Email already exists";

            var user = new User
            {
                Email = email,
                HashedPassword = password, // Za heshirane
                FirstName = firstName,
                Surname = surname,
                BirthDate = birthDate,
                Role = RoleType.User,
                ProfilePic = imgPath
            };

            await _service.AddAsync(user);
            return "User registered successfully";
        }

        public async Task<(bool Success, User? User, string Message)> LoginAsync(string email, string password)
        {
            var user = await _service.GetByEmailAsync(email);

            if (user == null) return (false, null, "Wrong email or password! Try again");
            if (user.HashedPassword != password) return (false, null, "Wrong email or password! Try again");

            return (true, user, "Login successful");
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            var users = await _service.GetAllAsync();
            return users.Where(u => u.Role != RoleType.Admin).ToList();
        }

        public Task<User?> GetProfileAsync(int userId)
        {
            return _service.GetByIdAsync(userId);
        }

        public async Task<string> UpdateProfileAsync(int userId, string firstName, string surname, string? profilePic, DateTime birthDate)
        {
            var user = await _service.GetByIdAsync(userId);
            if (user == null) return "User not found";

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(surname))
                return "Name fields are required";

            user.FirstName = firstName;
            user.Surname = surname;
            user.ProfilePic = profilePic;
            user.BirthDate = birthDate;

            await _service.UpdateAsync(user);
            return "Profile updated";
        }

        public async Task<string> DeleteUserAsync(User currentUser, int targetUserId)
        {
            if (currentUser.Role != RoleType.Admin) return "Only admin can delete users";

            var user = await _service.GetByIdAsync(targetUserId);
            if (user == null) return "User not found";

            await _service.DeleteAsync(user);
            return "User deleted";
        }

        public async Task<List<User>> SearchUsersAsync(string text)
        {
            var users = await _service.SearchAsync(text);
            return users.Where(u => u.Role != RoleType.Admin).ToList();
        }

        public async Task<string> FollowAsync(int currentUserId, int targetUserId)
        {
            if (currentUserId == targetUserId) return "You cannot follow yourself";

            var following = await _service.GetFollowingAsync(currentUserId);
            if (following.Any(u => u.Id == targetUserId)) return "Already following this user";

            await _service.FollowAsync(currentUserId, targetUserId);
            return "Followed successfully";
        }

        public async Task<string> UnfollowAsync(int currentUserId, int targetUserId)
        {
            var following = await _service.GetFollowingAsync(currentUserId);
            if (!following.Any(u => u.Id == targetUserId)) return "You are not following this user";

            await _service.UnfollowAsync(currentUserId, targetUserId);
            return "Unfollowed successfully";
        }

        public Task<List<User>> GetFollowersAsync(int userId)
        {
            return _service.GetFollowersAsync(userId);
        }

        public Task<List<User>> GetFollowingAsync(int userId)
        {
            return _service.GetFollowingAsync(userId);
        }
        public async Task<string> ImportUsersFromJsonAsync(string filePath)
        {
            if (!File.Exists(filePath)) return "JSON file not found.";

            string json = await File.ReadAllTextAsync(filePath);
            
            var result = await _service.ImportUsersFromJsonAsync(json);
            return result ? "Users imported successfully" : "Failed to import users";
        }
    }
}