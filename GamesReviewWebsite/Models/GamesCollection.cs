using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GamesReviewWebsite.Models
{
    public class GamesCollection
    {
       [Key]
        public virtual int Id { get; set; }
        [Required]
        public virtual int GameID { get; set; }
        [StringLength(100)]
        public virtual string GameDeveloper { get; set; }
        public virtual string GameGenre { get; set; }
        public virtual string GameName { get; set; }
        public virtual string GameDescription { get; set; }
        [Range(typeof(decimal), "0.00", "10.00")]
        public virtual decimal GameScore { get; set; }
        [Range(typeof(decimal), "3.00", "18.00")]
        public virtual decimal GameAgeRating { get; set; }
        public virtual Games Games { get; set; }
    }
}