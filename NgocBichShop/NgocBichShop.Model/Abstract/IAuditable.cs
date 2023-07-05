using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocBichShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescripton { get; set; }
        bool Status { get; set; }

    }
}
