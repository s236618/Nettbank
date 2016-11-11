using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nettbank.Model
{
        public class Account
        {
            [Display(Name = "KontoID")]
            public int id { get; set; }

            [Display(Name = "Navn")]
            [Required(ErrorMessage = "Navn må oppgis")]
            public string name { get; set; }

            [Display(Name = "Kontonummer")]
            [Required(ErrorMessage = "Kontonummer må oppgis")]
            public string accNumber { get; set; }

            [Display(Name = "Beløp")]
            [Required(ErrorMessage = "Beløp må oppgis")]
            public int balance { get; set; }

        }
}