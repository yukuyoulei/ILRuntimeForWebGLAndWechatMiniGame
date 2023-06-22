using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEntry : MonoBehaviour
{
    private static UIEntry sinstance;
    public static UIEntry Instance => sinstance;
    public Text Log;
    public InputField inputPrompt;
    public Button btnSend;
    void Start()
    {
        sinstance = this;
    }
    void OnLog(string log)
    {
        Log.text += log + "\r\n";
    }

    public static void DebugLog(string log)
    {
        sinstance.OnLog(log);
    }
}
