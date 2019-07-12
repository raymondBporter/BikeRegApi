using System;
using System.Collections.Generic;

namespace BikeReg
{
    public class BikeRegEventEntry
    {
        public string __type { get; set; }
        public double AmountDiscounted { get; set; }
        public double AmtPaid { get; set; }
        public string Bib { get; set; }
        public string CategoryName { get; set; }
        public string ConfirmationNumber { get; set; }
        public List<BikeRegCustomQuestion> CustomQuestions { get; set; }
        public DateTime DateEntered { get; set; }
        public int EID { get; set; }
        public decimal EntryFee { get; set; }
        public int EntryMethod { get; set; }
        public int EventID { get; set; }
        public bool? IsCheckedin { get; set; }
        public bool IsRaceDay { get; set; }
        public DateTime LastModified { get; set; }
        public string Notes { get; set; }
        public double PromoterTax { get; set; }
        public int Quantity { get; set; }
        public string RaceID { get; set; }
        public int RaceRecID { get; set; }
        public int TransactionType { get; set; }
        public BikeRegUserInfo UserInfo { get; set; }
    }
}
