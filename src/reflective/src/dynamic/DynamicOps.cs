//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct DynamicOps
    {
        [MethodImpl(Inline)]
        public static DynamicPointer pointer(DynamicDelegate src)
            => DynamicPointer.Define(src, pointer(src.TargetMethod));

        [MethodImpl(Inline)]
        public static DynamicPointer pointer<D>(DynamicDelegate<D> src)
            where D : Delegate
                => pointer(src.Untyped);

        /// <summary>
        /// Jits the methd and returns a pointer to the resulting method
        /// </summary>
        /// <param name="src">The soruce method</param>
        [MethodImpl(Inline)]
        public static IntPtr jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        [MethodImpl(Inline)]
        public static IntPtr jit(Delegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d);
            return d.Method.MethodHandle.GetFunctionPointer();
        }    

        [MethodImpl(Inline)]
        public static DynamicPointer jit(DynamicDelegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d.DynamicOp);
            return pointer(d);
        }        

        [MethodImpl(Inline)]
        public static DynamicPointer jit<D>(DynamicDelegate<D> d)
            where D : Delegate
                => jit(d.Untyped);

        [MethodImpl(Inline)]
        public static CilBody cil(DynamicMethod src)
            => CilBody.Define(src.Name, bytes(src), src.GetMethodImplementationFlags());

        [MethodImpl(Inline)]
        public static CilBody cil(MethodInfo src)
            => CilBody.Define(src.Name,src.GetMethodBody().GetILAsByteArray(), src.GetMethodImplementationFlags());

        [MethodImpl(Inline)]
        public static CilBody cil(DynamicDelegate src)
            => cil(src.TargetMethod);

        [MethodImpl(Inline)]
        public static CilBody cil<D>(DynamicDelegate<D> src)
            where D : Delegate
                => cil(src.Untyped);

        /// <summary>
        /// Finds the magical function pointer for a dynamic method
        /// </summary>
        /// <param name="method">The source method</param>
        /// <remarks>See https://stackoverflow.com/questions/45972562/c-sharp-how-to-get-runtimemethodhandle-from-dynamicmethod</remarks>
        static IntPtr pointer(DynamicMethod method)
        {
            var descriptor = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return ((RuntimeMethodHandle)descriptor.Invoke(method, null)).GetFunctionPointer();
        }

        /// <summary>
        /// See https://stackoverflow.com/questions/4148297/resolving-the-tokens-found-in-the-il-from-a-dynamic-method/35711376#35711376
        /// </summary>
        static byte[] bytes(DynamicMethod src)
        {            
            var resolver = typeof(DynamicMethod).GetField("m_resolver", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(src);
            if (resolver == null) throw new ArgumentException("The dynamic method's IL has not been finalized.");
            return (byte[])resolver.GetType().GetField("m_code", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(resolver);
        }
    }
}