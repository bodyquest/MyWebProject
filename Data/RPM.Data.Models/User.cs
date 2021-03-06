﻿namespace RPM.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;

    using RPM.Data.Common.Models;

    using static RPM.Common.GlobalConstants;

    public class User : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Homes = new HashSet<Home>();
            this.Rentals = new HashSet<Rental>();
            this.ManagedHomes = new HashSet<Home>();
            this.Contracts = new HashSet<Contract>();

            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        [Required]
        [MinLength(UsersNameMin)]
        [MaxLength(UsersNameMax)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(UsersNameMin)]
        [MaxLength(UsersNameMax)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public CloudImage ProfilePic { get; set; }

        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;

        [MaxLength(AboutMaxLength)]
        public string About { get; set; }

        // Stripe Properties
        public string StripeConnectedAccountId { get; set; }
        public string StripePublishableKey { get; set; }
        public string StripeRefreshToken { get; set; }

        // Collections
        public virtual ICollection<Home> Homes { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }

        public virtual ICollection<Home> ManagedHomes { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
