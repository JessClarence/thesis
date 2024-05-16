﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer.Enum;

namespace DomainLayer.Models
{
    public class MeatInspectionSummaryAndDistributionOfMIC
    {
        [Key]
        public int Id { get; set; }
        public string DestinationName { get; set; }
        public string DestinationAddress { get; set; }
        //  public CertificateStatus CertificateStatus { get; set; }
        public int MICIssued { get; set; }
        public int MICCancelled { get; set; }
		[ForeignKey("ReceivingReport")]
		public Guid ReceivingReportId { get; set; }
		public virtual MeatInspectionReceivingReport? ReceivingReport { get; set; }
	}
}