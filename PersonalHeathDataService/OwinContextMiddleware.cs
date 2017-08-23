using Microsoft.Owin;
using System.Threading.Tasks;

namespace PersonalHeathDataService
{
    public class OwinContextMiddleware : OwinMiddleware
    {
        public OwinContextMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            try
            {
                OwinCallContext.Set(context);
                await Next.Invoke(context);
            }
            finally
            {
                OwinCallContext.Remove(context);
            }
        }
    }
}