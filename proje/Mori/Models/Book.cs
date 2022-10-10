namespace Mori.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int Id { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(250)]
        public string UpdateBy { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string OrginalName { get; set; }

        [StringLength(20)]
        public string ISBN { get; set; }

        [StringLength(250)]
        public string Publisher { get; set; }

        public int? NumberOfPage { get; set; }

        public decimal? Width { get; set; }

        public decimal? Height { get; set; }

        [StringLength(250)]
        public string Type { get; set; }

        public decimal? Price { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [StringLength(50)]
        public string Alphabet { get; set; }

        public int? Year { get; set; }

        public int? Edition { get; set; }

        public int? PublishNo { get; set; }

        [StringLength(250)]
        public string Translator { get; set; }

        [StringLength(250)]
        public string Cover { get; set; }

        [StringLength(100)]
        public string ImageName { get; set; }

        public string Summary { get; set; }

        public int? Discount { get; set; }

        public int? Stok { get; set; }

        public bool? IsActive { get; set; }

        public bool? Doping { get; set; }

        public string Naverok { get; set; }

        public int? Priority { get; set; }

        [StringLength(200)]
        public string EbookGoogle { get; set; }

        [StringLength(200)]
        public string EbookEpirtuk { get; set; }
    }
}
