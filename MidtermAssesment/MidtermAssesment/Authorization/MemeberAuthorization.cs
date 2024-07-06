using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidtermAssesment.EF;

namespace MidtermAssesment.Authorization
{
        public class MemberAuthorization : AuthorizeAttribute
        {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var user = (User)httpContext.Session["user"];
            if (user != null && user.Type.Equals("Member"))
            {
                return true;
            }
            return false;
        }
    }

    }