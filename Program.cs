using System.Net;
using Rug.Osc;

IPAddress address = IPAddress.Parse("127.0.0.1");
int sendPort = 9000;
var oscSender = new OscSender(address, sendPort);
oscSender.Send(new OscMessage("/input/Jump", 1));
oscSender.Connect();
oscSender.Close();

Console.WriteLine("Hello, World!");
