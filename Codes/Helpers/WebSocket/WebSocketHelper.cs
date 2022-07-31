using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityWebSocket;

public static class WebSocketHelper
{
    public static WebSocketClient OnConnect(string connection
        , Action actionOpend
        , Action<MessageEventArgs> actionMessage
        , Action<CloseEventArgs> actionClose
        , Action<ErrorEventArgs> actionError
    )
    {
        return new WebSocketClient(connection, actionOpend, actionMessage, actionClose, actionError);
    }

}
