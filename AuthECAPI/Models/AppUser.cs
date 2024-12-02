using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthECAPI.Models
{
    public class AppUser:IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(150)")]
        public string FullName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(13)")]
        public string NIC {  get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }

        [PersonalData]
        public int? UTnumber { get; set; }
    }
}
