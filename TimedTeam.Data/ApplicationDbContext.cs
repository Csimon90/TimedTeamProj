using Microsoft.EntityFrameworkCore;
using TimedTeam.Data.Entities;

namespace TimedTeam.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<ReplyEntity> Replies { get; set; }
    }
}