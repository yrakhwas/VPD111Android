namespace WebSurok.Data.Entities.Identity
{
    using Microsoft.AspNetCore.Identity;
    public class RoleEntity : IdentityRole<long>
    {
        public virtual ICollection<UserRoleEntity> UserRoles { get; set; }
    }
}