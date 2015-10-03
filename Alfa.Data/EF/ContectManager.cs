using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Alfa.Infra.Repository
{
    public class ContextManager
    {
        private const string contextKey = "ContextManager.Context";

        public DbContext Context
        {
            get
            {
                if (HttpContext.Current.Items[contextKey] == null)
                    HttpContext.Current.Items[contextKey] = new Context();

                return (Context)HttpContext.Current.Items[contextKey];
            }
        }
    }
}
