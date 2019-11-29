using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using WindowsInput;
using WindowsInput.Native;

public class UdpSrvrSample
{
    public static void Main()
    {
        InputSimulator sim = new InputSimulator();
        UdpClient udpServer = new UdpClient(60668);

        while (true)
        {
            var remoteEP = new IPEndPoint(IPAddress.Any, 60668);
            var data = udpServer.Receive(ref remoteEP); // listen on port 11000
            Console.Write("receive data from " + remoteEP.ToString());
            if (remoteEP.ToString() == "192.168.1.39:60668")
            {


                // Press 0 key
                //sim.Keyboard.KeyPress(VirtualKeyCode.VK_G);

            }
        }
    }
}