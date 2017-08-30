namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_filter")]
    public class Filter
    {
        [Key]
        [Column("filter_id")]
        public int FilterId { get; set; }

        [Column("filter_group_id")]
        public int FilterGroupId { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
