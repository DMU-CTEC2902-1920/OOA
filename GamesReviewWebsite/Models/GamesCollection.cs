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
        public virtual int GameID { get; set; }
        public virtual string GameDeveloper { get; set; }
        public virtual string GameGenre { get; set; }
        public virtual decimal GameScore { get; set; }
        public virtual decimal GameAgeRating { get; set; }
        public virtual string GameName { get; set; }
        public virtual string GameDescription { get; set; }
        public virtual Games Games { get; set; }
    }
}