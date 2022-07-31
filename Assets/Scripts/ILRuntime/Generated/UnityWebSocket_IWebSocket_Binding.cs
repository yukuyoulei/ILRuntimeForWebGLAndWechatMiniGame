using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class UnityWebSocket_IWebSocket_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityWebSocket.IWebSocket);
            args = new Type[]{typeof(System.EventHandler<UnityWebSocket.OpenEventArgs>)};
            method = type.GetMethod("add_OnOpen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnOpen_0);
            args = new Type[]{typeof(System.EventHandler<UnityWebSocket.MessageEventArgs>)};
            method = type.GetMethod("add_OnMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnMessage_1);
            args = new Type[]{typeof(System.EventHandler<UnityWebSocket.ErrorEventArgs>)};
            method = type.GetMethod("add_OnError", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnError_2);
            args = new Type[]{typeof(System.EventHandler<UnityWebSocket.CloseEventArgs>)};
            method = type.GetMethod("add_OnClose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnClose_3);
            args = new Type[]{};
            method = type.GetMethod("ConnectAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ConnectAsync_4);


        }


        static StackObject* add_OnOpen_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.EventHandler<UnityWebSocket.OpenEventArgs> @value = (System.EventHandler<UnityWebSocket.OpenEventArgs>)typeof(System.EventHandler<UnityWebSocket.OpenEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityWebSocket.IWebSocket instance_of_this_method = (UnityWebSocket.IWebSocket)typeof(UnityWebSocket.IWebSocket).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnOpen += value;

            return __ret;
        }

        static StackObject* add_OnMessage_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.EventHandler<UnityWebSocket.MessageEventArgs> @value = (System.EventHandler<UnityWebSocket.MessageEventArgs>)typeof(System.EventHandler<UnityWebSocket.MessageEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityWebSocket.IWebSocket instance_of_this_method = (UnityWebSocket.IWebSocket)typeof(UnityWebSocket.IWebSocket).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnMessage += value;

            return __ret;
        }

        static StackObject* add_OnError_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.EventHandler<UnityWebSocket.ErrorEventArgs> @value = (System.EventHandler<UnityWebSocket.ErrorEventArgs>)typeof(System.EventHandler<UnityWebSocket.ErrorEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityWebSocket.IWebSocket instance_of_this_method = (UnityWebSocket.IWebSocket)typeof(UnityWebSocket.IWebSocket).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnError += value;

            return __ret;
        }

        static StackObject* add_OnClose_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.EventHandler<UnityWebSocket.CloseEventArgs> @value = (System.EventHandler<UnityWebSocket.CloseEventArgs>)typeof(System.EventHandler<UnityWebSocket.CloseEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityWebSocket.IWebSocket instance_of_this_method = (UnityWebSocket.IWebSocket)typeof(UnityWebSocket.IWebSocket).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnClose += value;

            return __ret;
        }

        static StackObject* ConnectAsync_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityWebSocket.IWebSocket instance_of_this_method = (UnityWebSocket.IWebSocket)typeof(UnityWebSocket.IWebSocket).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ConnectAsync();

            return __ret;
        }



    }
}
