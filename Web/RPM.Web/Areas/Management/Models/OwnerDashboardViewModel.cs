﻿namespace RPM.Web.Areas.Management.Models
{
    using System.Collections.Generic;

    using RPM.Services.Management.Models;

    public class OwnerDashboardViewModel
    {
        public IEnumerable<OwnerIndexListingsServiceModel> Properties { get; set; }

        public IEnumerable<OwnerIndexRequestsServiceModel> Requests { get; set; }

        public IEnumerable<OwnerIndexRentalServiceModel> Rentals { get; set; }

        public IEnumerable<OwnerAllPaymentsServiceModel> Payments { get; set; }

        public IEnumerable<OwnerAllTransactionRequestsServiceModel> TransactionRequests { get; set; }
    }
}
