using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Video.API.Authorization
{
    public class WhitelistHostFilterAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //1. Validate if the refer host from client is in the whitelist. if it is, admit it, otherwise, stop this request.
            base.OnActionExecuting(context);
        }
    }
}
