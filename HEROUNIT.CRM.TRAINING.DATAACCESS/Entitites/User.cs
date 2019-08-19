using System;
using System.Collections.Generic;
using System.Text;

namespace HEROUNIT.CRM.TRAINING.DATAACCESS.Entitites
{
    public class User: EntityBase
    {
        public String FullName { get; set; }
        public String UserName { get; set; }
    }
}
