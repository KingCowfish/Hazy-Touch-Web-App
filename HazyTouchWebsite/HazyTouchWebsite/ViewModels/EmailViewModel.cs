using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace HazyTouchWebsite.ViewModels
{
    public class EmailViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
