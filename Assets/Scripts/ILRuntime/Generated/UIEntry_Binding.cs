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
    unsafe class UIEntry_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::UIEntry);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("DebugLog", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DebugLog_0);
            args = new Type[]{};
            method = type.GetMethod("get_Instance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Instance_1);

            field = type.GetField("Log", flag);
            app.RegisterCLRFieldGetter(field, get_Log_0);
            app.RegisterCLRFieldSetter(field, set_Log_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Log_0, AssignFromStack_Log_0);
            field = type.GetField("inputPrompt", flag);
            app.RegisterCLRFieldGetter(field, get_inputPrompt_1);
            app.RegisterCLRFieldSetter(field, set_inputPrompt_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_inputPrompt_1, AssignFromStack_inputPrompt_1);
            field = type.GetField("btnSend", flag);
            app.RegisterCLRFieldGetter(field, get_btnSend_2);
            app.RegisterCLRFieldSetter(field, set_btnSend_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_btnSend_2, AssignFromStack_btnSend_2);


        }


        static StackObject* DebugLog_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @log = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            global::UIEntry.DebugLog(@log);

            return __ret;
        }

        static StackObject* get_Instance_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = global::UIEntry.Instance;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_Log_0(ref object o)
        {
            return ((global::UIEntry)o).Log;
        }

        static StackObject* CopyToStack_Log_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::UIEntry)o).Log;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Log_0(ref object o, object v)
        {
            ((global::UIEntry)o).Log = (UnityEngine.UI.Text)v;
        }

        static StackObject* AssignFromStack_Log_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Text @Log = (UnityEngine.UI.Text)typeof(UnityEngine.UI.Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::UIEntry)o).Log = @Log;
            return ptr_of_this_method;
        }

        static object get_inputPrompt_1(ref object o)
        {
            return ((global::UIEntry)o).inputPrompt;
        }

        static StackObject* CopyToStack_inputPrompt_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::UIEntry)o).inputPrompt;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_inputPrompt_1(ref object o, object v)
        {
            ((global::UIEntry)o).inputPrompt = (UnityEngine.UI.InputField)v;
        }

        static StackObject* AssignFromStack_inputPrompt_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.InputField @inputPrompt = (UnityEngine.UI.InputField)typeof(UnityEngine.UI.InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::UIEntry)o).inputPrompt = @inputPrompt;
            return ptr_of_this_method;
        }

        static object get_btnSend_2(ref object o)
        {
            return ((global::UIEntry)o).btnSend;
        }

        static StackObject* CopyToStack_btnSend_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::UIEntry)o).btnSend;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_btnSend_2(ref object o, object v)
        {
            ((global::UIEntry)o).btnSend = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_btnSend_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @btnSend = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::UIEntry)o).btnSend = @btnSend;
            return ptr_of_this_method;
        }



    }
}
