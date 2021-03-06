namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_banner_image")]
    public class BannerImage : IEntityWithTitle, ILocalizable
    {
        [Key]
        [Column("banner_image_id")]
        public int Id { get; protected set; }

        [Column("banner_id")]
        public int BannerId { get; set; }

        public virtual Banner Banner { get; set; }

        [Column("language_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }

        [Required]
        [StringLength(64)]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        [Column("link")]
        public string Link { get; set; }

        [Required]
        [StringLength(255)]
        [Column("image")]
        public string Image { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
