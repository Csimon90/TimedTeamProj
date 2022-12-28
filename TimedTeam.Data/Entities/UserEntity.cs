using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimedTeam.Data.Entities
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }

        public string Post { get; set; }
        public string Comment { get; set; }
        public string Reply { get; set; }
        public DbSet<UserEntity> Users{get; set;}
 
    }
}