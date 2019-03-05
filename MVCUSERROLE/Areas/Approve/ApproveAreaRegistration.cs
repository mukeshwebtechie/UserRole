using System.Web.Mvc;

namespace MVCUSERROLE.Areas.Approve
{
    public class ApproveAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Approve";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Approve_default",
                "Approve/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}