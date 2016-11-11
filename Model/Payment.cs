using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // denne må være med!
using System.Linq;
using System.Web;

namespace Nettbank.Model
{
    public class Payment
    {
        [Display(Name = "TransaksjonsID")]
        public int id { get; set; }

        [Display(Name = "Beløp")]
        [Required(ErrorMessage = "Beløp må oppgis")]
        public int amount { get; set; }

        [Display(Name = "Kontonummer")]
        [Required(ErrorMessage = "Kontonummer må oppgis")]
        [RegularExpression(@"[0-9]{11}", ErrorMessage = "Kontonummer må ha 11 siffer")]
        public string accNumber { get; set; }

        [Display(Name = "KID/Melding")]
        [Required(ErrorMessage = "KID eller melding må oppgis")]

        public string kid { get; set; }

        [Display(Name = "Dato")]
        [Required(ErrorMessage = "Dato må oppgis")]
        [RegularExpression(@"[0-9]{2}/[0-9]{2}/[0-9]{4}", ErrorMessage = "Dato må oppgis dd/mm/yyyy")]
        public string date { get; set; }
        
    }
}