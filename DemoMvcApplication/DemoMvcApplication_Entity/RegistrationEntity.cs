using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DemoMvcApplication_Entity
{
   public partial class RegistrationEntity
    {
        public int Id { get; set; }
       [Required]
        public string FullName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Emailid { get; set; }
        [Required]
        public string Gender { get; set; }
        public Nullable<long> Mobno { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
