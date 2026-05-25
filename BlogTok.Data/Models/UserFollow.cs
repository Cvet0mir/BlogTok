using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace BlogTok.Data.Models
{
    public class UserFollow
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Follower))]
        public int FollowerId { get; set; }
        public User Follower { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Following))]
        public int FollowingId { get; set; }
        public User Following { get; set; } = null!;
    }
}
