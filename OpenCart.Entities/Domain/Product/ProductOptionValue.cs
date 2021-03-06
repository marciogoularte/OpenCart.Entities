namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_product_option_value")]
    public class ProductOptionValue
    {
        [Key]
        [Column("product_option_value_id")]
        public int Id { get; protected set; }

        [Column("product_option_id")]
        public int ProductOptionId { get; set; }

        public virtual ProductOption ProductOption { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Column("option_id")]
        public int OptionId { get; set; }

        public virtual Option Option { get; set; }

        [Column("option_value_id")]
        public int OptionValueId { get; set; }

        public virtual OptionValue OptionValue { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("subtract")]
        public bool Subtract { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(1)]
        [Column("price_prefix")]
        public string PricePrefix { get; set; }

        [Column("points")]
        public int Points { get; set; }

        [Required]
        [StringLength(1)]
        [Column("points_prefix")]
        public string PointsPrefix { get; set; }

        [Column("weight")]
        public decimal Weight { get; set; }

        [Required]
        [StringLength(1)]
        [Column("weight_prefix")]
        public string WeightPrefix { get; set; }

        public virtual ICollection<OrderOption> OrderOptions { get; set; } = new HashSet<OrderOption>();
    }
}
