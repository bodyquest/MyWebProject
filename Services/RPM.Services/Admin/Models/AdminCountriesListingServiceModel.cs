﻿namespace RPM.Services.Admin.Models
{
    using System.ComponentModel.DataAnnotations;

    public class AdminCountriesListingServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Country Code")]
        public string Code { get; set; }
    }
}
