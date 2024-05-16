﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class MeatInspectionPassedForSlaughter
    {
        [Key]
        public Guid Id { get; set; }
        public int NumberOfHeads { get; set; }
        public double Weight { get; set; }
		[ForeignKey("ReceivingReport")]
		public Guid ReceivingReportId { get; set; }
		public virtual MeatInspectionReceivingReport? ReceivingReport { get; set; }
	}
}