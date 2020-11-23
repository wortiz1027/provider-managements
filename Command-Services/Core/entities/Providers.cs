using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities {

    [Table("Providers")]
    public class Providers {

        [Key, Column("ID_PROVIDER", Order = 1)]
        public string id { get; set; }

        [Column("NAME_PROVIDER", Order = 2)]
        public string name { get; set; }

        [Column("NIT", Order = 3)]
        public string nit { get; set; }

        [Column("ADDRESS", Order = 5)]
        public string address { get; set; }

        [Column("TELEPHONE", Order = 6)]
        public long telephone { get; set; }

        [Column("EMAIL", Order = 7)]
        public string email { get; set; }

        [Column("ID_COUNTRY", Order = 8)]
        public string idCountry { get; set; }

        [Column("ID_PROVINCE", Order = 9)]
        public string idProvince { get; set; }

        [Column("ID_CITY", Order = 10)]
        public string idCity { get; set; }

        [ForeignKey("ID_TYPE")]
        //public string IdType { get; set; }
        public Types types { get; set; }

    }

}