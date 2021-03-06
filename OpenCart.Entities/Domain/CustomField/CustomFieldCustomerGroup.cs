namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_custom_field_customer_group")]
    public class CustomFieldCustomerGroup
    {
        [Key]
        [Column("custom_field_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomFieldId { get; set; }

        public virtual CustomField CustomField { get; set; }

        [Key]
        [Column("customer_group_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerGroupId { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }

        [Column("required")]
        public bool Required { get; set; }
    }
}
