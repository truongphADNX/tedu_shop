using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public class AuditableSmall : IAuditableSmall
    {
        public DateTime? CreatedDate { get ; set ; }
        public string CreatedBy { get ; set ; }
        public bool Status { get ; set ; }
    }
}
