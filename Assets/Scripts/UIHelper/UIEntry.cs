using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEntry : MonoBehaviour
{
	private static UIEntry sinstance;
	Text Log;
	void Start()
	{
		sinstance = this;
		Log = transform.Find("Log").GetComponent<Text>();
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
