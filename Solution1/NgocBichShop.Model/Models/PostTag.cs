using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocBichShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(TypeName = "varchar", Order = 1)]
        public string TagID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int PostID { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
    }
}
