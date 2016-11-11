using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // denne må være med!
using System.Linq;
using System.Web;

namespace Nettbank.Model
{
    public class User
    {
        [Display(Name = "Personnummer")]
        [Required(ErrorMessage = "Må oppgi personnumer")]
        [RegularExpression(@"[0-9]{11}", ErrorMessage = "Personnummer består av 11 siffer.")]
        public long persNr { get; set; }

        [Display(Name = "Passord")]
        [Required(ErrorMessage = "Feil passord.")]
        //[RegularExpression(@"[a-zA-Z0-9]", ErrorMessage = "Ulovlig symbol benyttet, prøv igjen.")]
        public string password { get; set; }

        [Display(Name = "BankID")]
        [Required(ErrorMessage = "Feil bankID.")]
        //[RegularExpression(@"[a-zA-Z0-9]", ErrorMessage = "Ulovlig symbol benyttet, prøv igjen.")]
        public string tempCode { get; set; }

        [Display(Name = "Navn")]
        [Required(ErrorMessage = "Må oppgi navn")]
        public string name { get; set; }

        [Display(Name = "Adresse")]
        [Required(ErrorMessage = "Må oppgi adresse")]
        public string adress { get; set; }

        [Display(Name = "Postnummer")]
        [Required(ErrorMessage = "Må oppgi postkode")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "Postnr består av 4 siffer.")]
        public int zip { get; set; }
    }
}