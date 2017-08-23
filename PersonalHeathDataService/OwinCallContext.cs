using Microsoft.Owin;
using System.Runtime.Remoting.Messaging;

namespace PersonalHeathDataService
{
    public class OwinCallContext
    {
        private const string OwinContextKey = "owin.IOwinContext";

        public static IOwinContext Current
        {
            get { return (IOwinContext)CallContext.LogicalGetData(OwinContextKey); }
        }

        public static void Set(IOwinContext context)
        {
            CallContext.LogicalSetData(OwinContextKey, context);
        }

        public static void Remove(IOwinContext context)
        {
            CallContext.FreeNamedDataSlot(OwinContextKey);
        }
    }
}