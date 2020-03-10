using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesReviewWebsite.Models
{
    public class Games
    {
        public virtual int GameID { get; set; }
        public virtual string GameDescription { get; set; }
        public virtual string GameName { get; set; }
    }
}