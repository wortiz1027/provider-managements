using System.Collections.Generic;

namespace Core.Dtos {
    public class Types {

        public string Id { get; set; }

        public string Description { get; set; }

        public ICollection<Providers> Providers { get; set; }
    }

}