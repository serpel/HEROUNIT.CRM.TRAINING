using System;
using System.Collections.Generic;
using System.Text;

namespace HEROUNIT.CRM.TRAINING.DATAACCESS.Entitites
{
    public interface IAudited
    {
        DateTime CreationTime { get; set; }
        String CreatedBy { get; set; }
    }
}
