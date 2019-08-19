using System;
using System.Collections.Generic;
using System.Text;

namespace HEROUNIT.CRM.TRAINING.DATAACCESS.Entitites
{
    public class Quotation : EntityBase, IAudited
    {
        public int LeadId { get; set; }
        public DateTime CreationTime { get; set; }
        public string CreatedBy { get; set; }
        public virtual Lead Lead { get;set; }
        public virtual List<QuotationItem> QuotationItems { get; set; }

    }
}
