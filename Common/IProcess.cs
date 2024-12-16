using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// プロセス間通信インタフェース
    /// </summary>
    [ServiceContract]
    public interface IProcess
    {
        /// <summary>
        /// サーバー側でメソッドを実行し、戻り値をクライアントに渡す
        /// </summary>
        /// <param name="sec">処理秒数</param>
        /// <returns></returns>
        [OperationContract]
        int Execute(int sec);
    }
}
