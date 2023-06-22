using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Main : MonoBehaviour
{
    string configurl = "https://yukuyoulei.github.io/ILRuntimeForWebGLAndWechatMiniGame/Remote/config.txt";
    void Start()
    {
        UIEntry.DebugLog($"Downloading config {configurl}");
        StartLoadConfig();
    }

    private void StartLoadConfig()
    {
        StartCoroutine(DownloadConfig());
    }
    Dictionary<string, string> dConfigContents = new Dictionary<string, string>();
    IEnumerator DownloadConfig()
    {
        var www = UnityWebRequest.Get(configurl);
        yield return www.SendWebRequest();
        if(!string.IsNullOrEmpty(www.error))
        {
            UIEntry.DebugLog($"www.error {www.error}");
            yield return null;
        }
        var lines = www.downloadHandler.text.Split(new char[] { '\r', '\n' });
        foreach (var line in lines)
        {
            if (line.StartsWith("#"))
                continue;
            if (line.StartsWith("//"))
                continue;
            var l = line.Trim();
            if (string.IsNullOrEmpty(l))
                continue;
            var aline = l.Split(new char[] { '=' }, 2);
            if (aline.Length != 2)
                continue;
            dConfigContents[aline[0]] = aline[1];
        }
        var dll = GetConfig("dll");
        if (string.IsNullOrEmpty(dll))
        {
            UIEntry.DebugLog($"No dll to download");
            yield break;
        }
        UIEntry.DebugLog($"Download {dll}");
        www = UnityWebRequest.Get(dll);
        yield return www.SendWebRequest();
        var dllbytes = www.downloadHandler.data;
        UIEntry.DebugLog($"Download success, length {dllbytes.Length}");
        var pdb = GetConfig("pdb");
        byte[] pdbbytes = null;
        if (!string.IsNullOrEmpty(pdb))
        {
            www = UnityWebRequest.Get(dll);
            yield return www.SendWebRequest();
            pdbbytes = www.downloadHandler.data;
        }
        ILRuntimeHelper.LoadDll(dllbytes, pdbbytes, GetConfig("entryClass"), GetConfig("entryMethod"), dConfigContents);
    }
    private string GetConfig(string tag)
    {
        if (!dConfigContents.TryGetValue(tag, out var value))
            return "";
        return value;
    }

}
