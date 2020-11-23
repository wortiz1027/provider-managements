using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Core.Entities {

    [Table("Types")]
    public class Types {

        [Key, Column("TYPES_ID", Order = 1)]
        public string Id { get; set; }

        [Column("DESCRIPTION", Order = 2)]
        public string Description { get; set; }

        public ICollection<Providers> Providers { get; set; }
    }

}    