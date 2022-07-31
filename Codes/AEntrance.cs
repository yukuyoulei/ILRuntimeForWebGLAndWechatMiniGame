using System.Collections.Generic;

public static class AEntrance
{
    public static void Init(Dictionary<string, string> args)
    {
        UIEntry.DebugLog($"Hot class log changed!!!!");
        var wsc = new WebSocketConnector(args["ws"]);
    }
}
