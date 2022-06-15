using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailLayout
{
    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public bool IsColor { get; set; }
        public string Format { get; set; }
        public string Genre { get; set; }
    }
}
