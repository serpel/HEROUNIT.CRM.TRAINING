using System;
using System.Collections.Generic;
using System.Text;

namespace HEROUNIT.CRM.TRAINING.DATAACCESS.Entitites
{
    public class OrderItem: EntityBase, IAudited
    {
        public int OrderId {get;set;}
        public int Quanity { get; set; }
        public double Price { get; set; }
        public DateTime CreationTime { get; set; }
        public string CreatedBy { get; set; }
        public double GetTotal()
        {
            return Price * Quanity;
        }
        public virtual Order Order { get; set; }
    }
}
