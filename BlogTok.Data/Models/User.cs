using BlogTok.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTok.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(250)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string HashedPassword { get; set; } = null!;

        [Required]
        [StringLength(150)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(150)]
        public string Surname { get; set; } = null!;

        [Required]
        public DateTime BirthDate { get; set; }
        public string? ProfilePic { get; set; }

        [Required]
        [EnumDataType(typeof(RoleType))]
        public RoleType Role { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<UserFollow> Followers { get; set; } = new List<UserFollow>();
        public ICollection<UserFollow> Following { get; set; } = new List<UserFollow>();
        public ICollection<Reaction> Reactions { get; set; } = new List<Reaction>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<CommentReaction> CommentReactions { get; set; } = new List<CommentReaction>();

    }
}
