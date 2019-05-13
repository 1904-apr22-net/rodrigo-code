using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.DA.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }
       // public Genre Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        //Foreign key column is not necessary 

        //navigation properties

        public virtual Genre Genre { get; set; }
    }
}
