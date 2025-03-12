using System.Net;
using Rug.Osc;

IPAddress address = IPAddress.Parse("127.0.0.1");
int sendPort = 9000;
var oscSender = new OscSender(address, 0, sendPort);

oscSender.Connect();
oscSender.Send(new OscMessage("/input/Jump", 1));
System.Threading.Thread.Sleep(10);
oscSender.Send(new OscMessage("/input/Jump", 0));
oscSender.Close();