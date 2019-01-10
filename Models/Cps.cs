using System;
using System.Collections.Generic;

namespace cpsAngular.Models
{
    public partial class Cps
    {
        public int Id { get; set; }
        public int CaseNumber { get; set; }
        public int? Po12 { get; set; }
        public string Section { get; set; }
        public string ProductFamily { get; set; }
        public string ProductFamilySubType { get; set; }
        public string ProductDescription { get; set; }
        public int? PartNumber { get; set; }
        public double? ListPrice { get; set; }
        public double? Discount { get; set; }
        public string UsageIndicator { get; set; }
        public DateTime? UsageStartDate { get; set; }
        public string UnitOfMeasure { get; set; }
        public int? UnitQuantity { get; set; }
        public double? NetUnitPrice { get; set; }
        public int? LicenseQuantity { get; set; }
        public string UsageCountry { get; set; }
        public double? ExtendedAmount { get; set; }
    }
}
