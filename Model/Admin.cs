using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nettbank.Model
{
    public class Admin
    {
        [Display(Name = "Brukernavn")]
        [Required(ErrorMessage = "Må oppgi brukernavn")]
        public string userName { get; set; }

        [Display(Name = "Passord")]
        [Required(ErrorMessage = "Feil passord.")]
        //[RegularExpression(@"[a-zA-Z0-9]", ErrorMessage = "Ulovlig symbol benyttet, prøv igjen.")]
        public string password { get; set; }
    }
}
