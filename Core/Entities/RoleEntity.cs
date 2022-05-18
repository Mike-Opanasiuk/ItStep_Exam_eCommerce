using Core.Entities.Abstract;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities
{
    public class RoleEntity:IdentityRole<Guid>, IEntity
    {
        public RoleEntity(string roleName) : base(roleName)
        {
        }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
