using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesReviewWebsite.Models
{
    public class GamesReview
    {
        public int Id { get; set; }
        public int GameID { get; set; }
        public string GameDeveloper { get; set; }
        public string GameGenre { get; set; }
        public decimal GameScore { get; set; }
        public decimal GameAgeRating { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public Games Games { get; set; }
    }

    
}