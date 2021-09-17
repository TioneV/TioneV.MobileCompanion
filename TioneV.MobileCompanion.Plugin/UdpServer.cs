using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TioneV.MobileCompanion.Plugin
{
    public class UdpServer : IDisposable
    {
        public const int DEFAULT_LISTEN_PORT = 56511;

        private readonly UdpClient _udp;
        private readonly IPEndPoint _endpoint;
        private readonly IPEndPoint _broadcastEndpoint;
        private bool _started;

        public UdpServer(int udpListenPort = DEFAULT_LISTEN_PORT)
        {
            _broadcastEndpoint = new IPEndPoint(IPAddress.Broadcast, udpListenPort);
            _endpoint = new IPEndPoint(IPAddress.Any, udpListenPort);
            _udp = new UdpClient(_endpoint);
            _udp.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            _udp.ExclusiveAddressUse = false;
        }

        public void Start()
        {
            _udp.Client.Bind(_broadcastEndpoint);
            _udp.BeginReceive(new AsyncCallback(this.ReceiveCallback), null);
            _started = true;
        }

        private void ReceiveCallback(IAsyncResult result)
        {
            if(!_started) return; 

            IPEndPoint remoteEndpoint = null;
            byte[] data = _udp.EndReceive(result, ref remoteEndpoint);
        }

        public void Stop()
        {
            _started = false;
            _udp?.Client?.Close();
            _udp?.Close();
        }

        public void Dispose()
        {
            this.Stop();
            _udp?.Dispose();
        }
    }
}
