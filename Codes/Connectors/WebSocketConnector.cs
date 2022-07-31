using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityWebSocket;

public class WebSocketConnector
{
    WebSocketClient client;
    private static SynchronizationContext mainThreadSynContext;

    public WebSocketConnector(string connection)
    {
        mainThreadSynContext = SynchronizationContext.Current;
        UIEntry.DebugLog($"[WebSocketConnector]{connection}");
        client = WebSocketHelper.OnConnect(connection, OnOpen, OnMessage, OnClose, OnError);
    }

    private void OnError(ErrorEventArgs e)
    {
        mainThreadSynContext.Post(new SendOrPostCallback(o =>
        {
            UIEntry.DebugLog($"[WebSocket_OnError]{e.Exception}");
        }), null);
    }

    private void OnClose(CloseEventArgs e)
    {
        mainThreadSynContext.Post(new SendOrPostCallback(o =>
        {
            UIEntry.DebugLog($"[WebSocket_OnClose]{e.Code} {e.Reason}");
        }), null);
    }

    private void OnMessage(MessageEventArgs e)
    {
//         mainThreadSynContext.Post(new SendOrPostCallback(o =>
//         {
            UIEntry.DebugLog($"[WebSocket_OnMessage]{e.Data}");
        //}), null);
    }

    private void OnOpen()
    {
//         mainThreadSynContext.Post(new SendOrPostCallback(o =>
//         {
            UIEntry.DebugLog($"[WebSocket_OnOpen]");
        //}), null);
    }
}
