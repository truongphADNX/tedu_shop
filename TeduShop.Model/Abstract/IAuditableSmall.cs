using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;       

namespace TeduShop.Model.Abstract
{
    internal interface IAuditableSmall
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        bool Status { set; get; }
    }
}
