using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    [Table("Tournaments")]
    public class Tournament
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        [Required, MaxLength(200)]
        public String Name { get; set; }

        [DataTypeAttribute(DataType.Date), Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual ICollection<Competitor> Competitors { get; set; }
    }
}