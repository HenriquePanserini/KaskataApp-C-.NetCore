using System.ComponentModel.DataAnnotations.Schema;
using KaskataDDD.Infrastructure.Enums;
using Microsoft.AspNetCore.Identity;

namespace KaskataDDD.Infrastructure.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USR_AGE")]
        public int Age { get; set; }
        [Column("USR_PHONE")]
        public string Phone {  get; set; }
        [Column("USR_TYPE")]
        public UserType? UserType { get; set; }
    }
}
