using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HEROUNIT.CRM.TRAINING.DATAACCESS.Entitites
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
