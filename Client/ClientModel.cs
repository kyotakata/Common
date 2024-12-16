using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class ClientModel
    {
        private IProcess _Server;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ClientModel()
        {
            _Server = new ChannelFactory<IProcess>(
        new NetNamedPipeBinding(),
        new EndpointAddress(Service.GetAddress())
        ).CreateChannel();

        }


        /// <summary>
        /// プロセス間通信実行
        /// </summary>
        /// <returns></returns>
        public int ExecuteServerSide()
        {
            return _Server.Execute(5);
        }

    }
}
