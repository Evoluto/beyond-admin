using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeyondThemes.BeyondAdmin.Models
{
    public class ProjectViewModel
    {
        [Display(Name ="Agency")]
        public string Tbl385_agency_name { get; set; }
        [Display(Name = "Island")]
        public string Tbl386_custom_island { get; set; }
        [Display(Name = "PA Category")]
        public string Tbl386_custom_pa_category { get; set; }
        [Display(Name = "PW #")]
        public string Tbl386_custom_pw_number { get; set; }
        [Display(Name = "Sector")]
        public string Tbl386_custom_sector { get; set; }
        [Display(Name = "Project")]
        public string Tbl386_name { get; set; }
        public string Id { get; set; }
        //public string description { get; set; }
    }

    public class TokenViewModel
    {
        public string Access_token { get; set; }
        public string Token_type { get; set; }
        public string Expires_in { get; set; }
        public string Client_id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
    };
}