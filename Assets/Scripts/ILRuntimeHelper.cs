using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class ILRuntimeHelper
{
    static ILRuntime.Runtime.Enviorment.AppDomain appdomain;
    public static void LoadDll(byte[] dll, byte[] pdb, string entryClass, string entryMethod)
    {
        appdomain = new ILRuntime.Runtime.Enviorment.AppDomain(ILRuntime.Runtime.ILRuntimeJITFlags.JITOnDemand);
        appdomain.LoadAssembly(new MemoryStream(dll), pdb == null ? null : new MemoryStream(pdb), new ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());
        InitializeILRuntime();
        OnHotFixLoaded(entryClass, entryMethod);
    }
    static void InitializeILRuntime()
    {
#if DEBUG && (UNITY_EDITOR || UNITY_ANDROID || UNITY_IPHONE)
        //由于Unity的Profiler接口只允许在主线程使用，为了避免出异常，需要告诉ILRuntime主线程的线程ID才能正确将函数运行耗时报告给Profiler
        appdomain.UnityMainThreadID = System.Threading.Thread.CurrentThread.ManagedThreadId;
#endif
        //这里做一些ILRuntime的注册，HelloWorld示例暂时没有需要注册的
    }
    static void OnHotFixLoaded(string entryClass, string entryMethod)
    {
        //HelloWorld，第一次方法调用
        UIEntry.DebugLog($"OnHotFixLoaded {entryClass} {entryMethod}");
        appdomain.Invoke(entryClass, entryMethod, null, null);
    }
}
