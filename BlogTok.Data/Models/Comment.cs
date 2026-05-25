using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTok.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Content { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public Post Post { get; set; } = null!;

        public ICollection<CommentReaction> CommentReactions { get; set; } = new List<CommentReaction>();
    }
}
