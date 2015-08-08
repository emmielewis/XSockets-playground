##XSockets.Sample.WebRTC is installed

###Steps for running the XSockets.WebRTC sample

1: Add this class under the App_Start folder

	using System.Web;
	using XSockets.Core.Common.Socket;

	[assembly: PreApplicationStartMethod(typeof(VideoChatDemo.App_Start.xbooter), "Start")]
	namespace VideoChatDemo.App_Start
	{
		public static class xbooter
		{
			private static IXSocketServerContainer container;
			public static void Start()
			{
				container = XSockets.Plugin.Framework.Composable.GetExport<IXSocketServerContainer>();
				container.Start();
			}
		}
	}

2: Hit F5 to start debug

3: Navigate to http://localhost:xxxx/WebRTC/Client/index.html
   where xxxx should be the port for your application.