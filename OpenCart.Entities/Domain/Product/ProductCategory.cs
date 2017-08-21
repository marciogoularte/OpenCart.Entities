namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_product_to_category")]
    public class ProductCategory
    {
        public ProductCategory()
        {
        }

        public ProductCategory(Category category, bool isMainCategory = false)
        {
            CategoryId = category.Id;
            Category = category;
            IsMainCategory = isMainCategory;
        }

        [Key, Column("product_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; protected set; }

        public virtual Product Product { get; protected set; }

        [Key, Column("category_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; protected set; }

        public virtual Category Category { get; protected set; }

        [Column("main_category")]
        public bool IsMainCategory { get; set; }
    }
}