namespace ExactOnline.Client.Models.FinancialTransaction
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("EntryID")]
    public class CashEntry
    {
        /// <summary>Collection of lines</summary>
        public IEnumerable<CashEntryLine> CashEntryLines { get; set; }

        /// <summary>Closing balance in the currency of the transaction</summary>
        public double? ClosingBalanceFC { get; set; }

        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }

        /// <summary>Currency code</summary>
        public string Currency { get; set; }

        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }

        /// <summary>Primary key</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid EntryID { get; set; }

        /// <summary>Entry number</summary>
        public Int32? EntryNumber { get; set; }

        /// <summary>Fiancial period</summary>
        public Int16? FinancialPeriod { get; set; }

        /// <summary>Fiancial year</summary>
        public Int16? FinancialYear { get; set; }

        /// <summary>Code of Journal</summary>
        public string JournalCode { get; set; }

        /// <summary>Description of Journal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }

        /// <summary>Opening balance in the currency of the transaction</summary>
        public double? OpeningBalanceFC { get; set; }

        /// <summary>Status: 5 = Rejected, 20 = Open, 50 = Processed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Status { get; set; }

        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
    }
}
