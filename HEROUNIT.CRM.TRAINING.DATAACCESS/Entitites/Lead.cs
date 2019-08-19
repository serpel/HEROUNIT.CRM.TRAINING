using HEROUNIT.CRM.TRAINING.DATAACCESS.Entitites;
using System;
using System.ComponentModel.DataAnnotations;

namespace HEROUNIT.CRM.TRAINING.DATAACCESS.Entitites
{
    public enum PersonGenre {
        MALE = 1,
        FAMELE = 2
    }

    public class Lead : EntityBase, IAudited
    {
        public string PersonName { get; set; }
        public PersonGenre Genre { get; set; }
        public string Company { get; set; }
        public int FollowPersonId { get; set; }
        public DateTime CreationTime { get; set; }
        public string CreatedBy { get; set; }
        public virtual User User { get; set; }
    }
}
