using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidtermAssesment.EF;


namespace MidtermAssesment.Authorization
{
        public class Logged : AuthorizeAttribute
        {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["User"] != null)
            {
                return true;
            }
            return false;
        }
    }
    }