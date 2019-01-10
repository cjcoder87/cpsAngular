using System;
using System.Collections.Generic;

namespace cpsAngular.Models
{
    public partial class FinalValues
    {
        public int Id { get; set; }
        public int CaseNumber { get; set; }
        public int? Po12 { get; set; }
        public string Po12overrideReason { get; set; }
        public string Section { get; set; }
        public string SectionOverrideReason { get; set; }
        public string ProductFamily { get; set; }
        public string ProductFamilyOverrideReason { get; set; }
        public string ProductFamilySubType { get; set; }
        public string ProductFamilySubTypeOverrideReason { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDescriptionOverrideReason { get; set; }
        public int? PartNumber { get; set; }
        public string PartNumberOverrideReason { get; set; }
        public double? ListPrice { get; set; }
        public string ListPriceOverrideReason { get; set; }
        public double? Discount { get; set; }
        public string DiscountOverrideReason { get; set; }
        public string UsageIndicator { get; set; }
        public string UsageIndicatorOverrideReason { get; set; }
        public DateTime? UsageStartDate { get; set; }
        public string UsageStartDateOverrideReason { get; set; }
        public string UnitOfMeasure { get; set; }
        public string UnitOfMeasureOverrideReason { get; set; }
        public int? UnitQuantity { get; set; }
        public string UnitQuantityOverrideReason { get; set; }
        public double? NetUnitPrice { get; set; }
        public string NetUnitPriceOverrideReason { get; set; }
        public int? LicenseQuantity { get; set; }
        public string LicenseQuantityOverrideReason { get; set; }
        public string UsageCountry { get; set; }
        public string UsageCountryOverrideReason { get; set; }
        public double? ExtendedAmount { get; set; }
        public string ExtendedAmountOverrideReason { get; set; }
    }
}
