using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamHoffman_S00197432
{
    public class Game
    {
        [Key]
        public string Name { get; set; }
        public string MetaCriticScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
        public decimal ReducedPrice { get; set; }
        public string Game_image { get; set; }

        public override string ToString()
        {
            return Name;
        }


        public void DecreasePeice(decimal reduction)
        {
            Price = Price - reduction;
        }
    }
    public class GAMESdata : DbContext
    {
        public GAMESdata() : base("MyGamesData") { }
        public DbSet<Game> Games { get; set; }
    }
}
