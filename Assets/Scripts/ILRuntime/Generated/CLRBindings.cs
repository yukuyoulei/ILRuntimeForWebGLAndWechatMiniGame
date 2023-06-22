using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {

//will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        static private void RegisterBindingAction()
        {
            ILRuntime.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);
        }

        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3> s_UnityEngine_Vector3_Binding_Binder = null;
        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2> s_UnityEngine_Vector2_Binding_Binder = null;
        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion> s_UnityEngine_Quaternion_Binding_Binder = null;

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            UIEntry_Binding.Register(app);
            UnityEngine_UI_Button_Binding.Register(app);
            UnityEngine_Events_UnityEvent_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_String_Binding.Register(app);
            System_Int32_Binding.Register(app);
            System_String_Binding.Register(app);
            System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Binding.Register(app);
            UnityEngine_UI_InputField_Binding.Register(app);
            UnityEngine_Networking_UnityWebRequest_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_Binding.Register(app);
            UnityEngine_Networking_DownloadHandler_Binding.Register(app);
            System_Threading_Tasks_TaskCompletionSource_1_Object_Binding.Register(app);
            UnityEngine_AsyncOperation_Binding.Register(app);
            System_Threading_Tasks_Task_Binding.Register(app);
            System_Threading_SynchronizationContext_Binding.Register(app);
            UnityWebSocket_MessageEventArgs_Binding.Register(app);
            UnityWebSocket_ErrorEventArgs_Binding.Register(app);
            UnityWebSocket_CloseEventArgs_Binding.Register(app);
            System_Action_1_CloseEventArgs_Binding.Register(app);
            System_Action_1_ErrorEventArgs_Binding.Register(app);
            System_Action_Binding.Register(app);
            System_Action_1_MessageEventArgs_Binding.Register(app);
            UnityWebSocket_WebSocket_Binding.Register(app);
            UnityWebSocket_IWebSocket_Binding.Register(app);

            ILRuntime.CLR.TypeSystem.CLRType __clrType = null;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Vector3));
            s_UnityEngine_Vector3_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3>;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Vector2));
            s_UnityEngine_Vector2_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2>;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Quaternion));
            s_UnityEngine_Quaternion_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion>;
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy
        /// </summary>
        public static void Shutdown(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            s_UnityEngine_Vector3_Binding_Binder = null;
            s_UnityEngine_Vector2_Binding_Binder = null;
            s_UnityEngine_Quaternion_Binding_Binder = null;
        }
    }
}
