namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
