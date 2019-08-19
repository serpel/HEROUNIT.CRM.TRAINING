using System;
using System.Collections.Generic;
using System.Text;

namespace HEROUNIT.CRM.TRAINING.DATAACCESS.Entitites
{
    public class Order : EntityBase, IAudited
    {
        public DateTime CreationTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
