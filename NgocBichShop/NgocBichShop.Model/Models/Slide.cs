﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocBichShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string Description { get; set; }
        [Required]
        [MaxLength(500)]
        public string Image { get; set; }
        [Required]
        [MaxLength(500)]
        public string URL { get; set; }
        public int? DisplayOrder { get; set; }
        public bool Status { get; set; }
        public string Content { set; get; }

    }
}
