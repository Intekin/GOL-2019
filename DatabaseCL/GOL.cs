namespace DatabaseCL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GOL")]
    public partial class GOL
    {
        [StringLength(2147483647)]
        public string Name { get; set; }

        [StringLength(2147483647)]
        public string DOA { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long GOL_Id { get; set; }
    }
}
