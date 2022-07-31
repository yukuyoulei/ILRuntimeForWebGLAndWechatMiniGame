using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using UnityWebSocket;

public class WebSocketClient
{
    private IWebSocket WebSocket;
    Action actionOpend;
    Action<CloseEventArgs> actionClose;
    Action<MessageEventArgs> actionMessage;
    Action<ErrorEventArgs> actionError;
    public WebSocketClient(string connection
        , Action actionOpend
        , Action<MessageEventArgs> actionMessage
        , Action<CloseEventArgs> actionClose
        , Action<ErrorEventArgs> actionError
        )
    {
        this.actionOpend = actionOpend;
        this.actionClose = actionClose;
        this.actionError = actionError;
        this.actionMessage = actionMessage;
        WebSocket = new UnityWebSocket.WebSocket(connection);
        WebSocket.OnOpen += WebSocket_OnOpen; ;
        WebSocket.OnMessage += WebSocket_OnMessage;
        WebSocket.OnError += WebSocket_OnError;
        WebSocket.OnClose += WebSocket_OnClose;
        WebSocket.ConnectAsync();
    }

    private void WebSocket_OnClose(object sender, CloseEventArgs e)
    {
        actionClose?.Invoke(e);
    }

    private void WebSocket_OnError(object sender, ErrorEventArgs e)
    {
        actionError?.Invoke(e);
    }

    private void WebSocket_OnOpen(object sender, OpenEventArgs e)
    {
        actionOpend?.Invoke();
    }

    private void WebSocket_OnMessage(object sender, MessageEventArgs e)
    {
        actionMessage?.Invoke(e);
    }
}
