using System;
using System.Collections.Generic;

namespace BikeReg
{
    public class BikeRegEvent
    {
        public string __type { get; set; }
        public DateTime CloseRegDate { get; set; }
        public string EventID { get; set; }
        public string EventName { get; set; }
        public int PromoterID { get; set; }
        public string PromoterTaxName { get; set; }
        public double PromoterTaxPercentage { get; set; }
        public bool RaceDay { get; set; }
        public string RaceDayRegistrationCode { get; set; }
        public double RaceDaySurcharge { get; set; }
        public string EventPermit { get; set; }
        public bool IsNACSPermitOnly { get; set; }
        public string OneDayLicenseFee { get; set; }
        public string RacePredictor { get; set; }
        public string SanctioningBody { get; set; }
        public bool ShowUSACWaiver { get; set; }
        public List<BikeRegEventCategory> Categories { get; set; }
    }
}
