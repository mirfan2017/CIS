//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CardIssuanceSystem.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Requests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Requests()
        {
            this.tbl_Request_Customer_Accounts = new HashSet<tbl_Request_Customer_Accounts>();
        }
    
        public long ID { get; set; }
        public string RequestType { get; set; }
        public string AccountNo { get; set; }
        public string CIFNo { get; set; }
        public string CardNo { get; set; }
        public Nullable<bool> WaiveCharges { get; set; }
        public Nullable<bool> StatusEligibility { get; set; }
        public Nullable<bool> FinancialEligibility { get; set; }
        public string AuthorizationComments { get; set; }
        public string AuthorizationStatus { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string CardTitle { get; set; }
        public Nullable<int> CardTypeID { get; set; }
        public string Salutation { get; set; }
        public string LinkingDelinkingAccount { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsExported { get; set; }
        public Nullable<int> CreatorID { get; set; }
        public Nullable<int> AuthorizerID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Request_Customer_Accounts> tbl_Request_Customer_Accounts { get; set; }
    }
}