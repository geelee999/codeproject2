using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using codeproject2.Database;

namespace codeproject2.Models
{
    public class NewsletterViewModel
    {
        public NewsletterViewModel()
        {
            this.Newsletters = new List<Newsletter>();
        }

        public List<Newsletter> Newsletters { get; set; }

        [Required]
        [MinLength(6)]
        public string Email { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(4096)]
        public string Comment { get; set; }

        [Required]
        public int SelectedId { get; set; }

    }
}