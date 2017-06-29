using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    [Table("Competitors")]
    public class Competitor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        public Int64 TournamentId { get; set; }

        [ForeignKey("TournamentId")]
        public Tournament Tournament { get; set; }

        public Int64 PlayerId { get; set; }

        [ForeignKey("PlayerId")]
        public Player Player { get; set; }
    }
}