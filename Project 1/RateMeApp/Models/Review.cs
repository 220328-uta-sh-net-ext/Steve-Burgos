using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Review
    {
        public int ID { get; set; }
        public int RestaurantID { get; set; }
        public int UserID { get; set; }
        public int Score { get; set; }
        public string? WrittenReview  { get; set; }

    }
}
