using System;
using System.Collections.Generic;
using System.Text;

namespace HEROUNIT.CRM.TRAINING.DATAACCESS.Entitites
{
    public class QuotationItem : EntityBase
    {
        public int QuotationId { get; set; }
        public int ProductId {get;set;}
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double GetTotal()
        {
            return this.Quantity * Price;
        }
        public virtual Product Product { get; set; }
        public virtual Quotation Quotation { get; set; }
    }
}
