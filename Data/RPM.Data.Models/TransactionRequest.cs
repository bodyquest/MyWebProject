﻿namespace RPM.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;
    using RPM.Data.Models.Enums;

    using static RPM.Common.GlobalConstants;

    public class TransactionRequest
    {
        public TransactionRequest()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Date = DateTime.UtcNow;
            this.PaymentDate = DateTime.UtcNow.Date;
            this.Status = TransactionRequestStatus.Scheduled;
        }

        public string Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime PaymentDate { get; set; } 

        [Required]
        public string RecipientId { get; set; }

        [ForeignKey("RecipientId")]
        public virtual User Recipient { get; set; }

        [Required]
        public string SenderId { get; set; }

        [ForeignKey("SenderId")]
        public virtual User Sender { get; set; }

        [Required]
        [MaxLength(ReasonMaxLength)]
        public string Reason { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public RecurringScheduleType RecurringSchedule { get; set; }

        public TransactionRequestStatus Status { get; set; }

        [ForeignKey(nameof(Rental))]
        public int? RentalId { get; set; }
        public virtual Rental Rental { get; set; }

        [ForeignKey(nameof(Home))]
        public string HomeId { get; set; }
        public virtual Home Home { get; set; }

        public bool IsRecurring { get; set; }
    }
}
