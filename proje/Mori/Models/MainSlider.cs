namespace Mori.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainSlider")]
    public partial class MainSlider
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Url { get; set; }

        [StringLength(250)]
        public string ImageName { get; set; }

        public int? SliderType { get; set; }

        public int? SliderStatus { get; set; }
    }
}
