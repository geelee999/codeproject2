namespace codeproject2.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(256)]
        public string Email { get; set; }

        public int EditionId { get; set; }

        [Required]
        [MinLength(3)]
        public string Content { get; set; }
    }
}
