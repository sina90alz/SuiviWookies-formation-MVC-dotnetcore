using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Models
{
    public class WookieViewModel
    {
        private Wookie _wookie;

        public WookieViewModel(Wookie wookie = null)
        {
            if (wookie == null)
            {
                wookie = new Wookie();
            }


            this._wookie = wookie;
        }

        [Required]
        //[Required(AllowEmptyStrings =false, ErrorMessage ="Libellé est necessaire")]
        [StringLength(20, ErrorMessage = "Attention to the length")]
        //To check the unicité of Surname a methode in Wookies controller
        [Remote("VerifyUnique", "Wookies", HttpMethod = "Post", ErrorMessage = "Le surname doit etre unqiue")]
        public string Surname { get => this._wookie.Surname; set => this._wookie.Surname = value; }

        /// <summary>
        /// This is an example prop If a integer property is added, the verification can be proceeded as below
        /// </summary>
        //[Required]
        //[Range(0, 500)]
        //public int Power { get; set; }

        public Wookie Wookie { get => this._wookie; }

        public IList<Weapon> Weapons { get; set; }
    }
}
