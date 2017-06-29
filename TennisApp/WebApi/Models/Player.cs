using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    [Table("Players")]
    public class Player
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        [Required, MaxLength(50)]
        public String LastName { get; set; }

        [Required, MaxLength(50)]
        public String FirstName { get; set; }
        
        [MaxLength(50)]
        public String MiddleName { get; set; }

        [DataTypeAttribute(DataType.Date)]
        public DateTime Birthday { get; set; }

        public byte[] Photo { get; set; }

        public virtual ICollection<Competitor> Competitors {get; set;}
    }
}