using System.Web;
using XSockets.Core.Common.Socket;
using XSockets.Plugin.Framework;

[assembly: PreApplicationStartMethod(typeof(XSockets_playground.XSockets), "Start")]
namespace XSockets_playground
{
    public static class XSockets
    {
        private static IXSocketServerContainer container;
        public static void Start()
        {
            container = Composable.GetExport<IXSocketServerContainer>();
            container.Start();
        }
    }
}
