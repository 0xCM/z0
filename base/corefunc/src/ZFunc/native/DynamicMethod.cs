//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Emit;
    using System.Runtime.Intrinsics;
    using System.IO;

    using static zfunc;

    public static class DynamicMethodX
    {
        /// <summary>
        /// Finds the magical function pointer for a dynamic method
        /// </summary>
        /// <param name="method">The source method</param>
        /// <remarks>See https://stackoverflow.com/questions/45972562/c-sharp-how-to-get-runtimemethodhandle-from-dynamicmethod</remarks>
        public static IntPtr GetFunctionPointer(this DynamicMethod method)
        {
            var descriptor = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return ((RuntimeMethodHandle)descriptor.Invoke(method, null)).GetFunctionPointer();
        }

        public static unsafe DynamicPointer GetDynamicPointer(this DynamicDelegate src)
        {
            var ptr = src.DynamicMethod.GetFunctionPointer();
            return new DynamicPointer(src, (byte*)ptr.ToPointer());
        }

        public static unsafe DynamicPointer GetDynamicPointer<D>(this DynamicDelegate<D> src)
            where D : Delegate
        {
            var ptr = src.DynamicMethod.GetFunctionPointer();
            return new DynamicPointer(src, (byte*)ptr.ToPointer());
        }

        /// <summary>
        /// See https://stackoverflow.com/questions/4148297/resolving-the-tokens-found-in-the-il-from-a-dynamic-method/35711376#35711376
        /// </summary>
        public static byte[] CilBody(this DynamicMethod src)
        {            
            var resolver = typeof(DynamicMethod).GetField("m_resolver", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(src);
            if (resolver == null) throw new ArgumentException("The dynamic method's IL has not been finalized.");
            return (byte[])resolver.GetType().GetField("m_code", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(resolver);
        }

        public static byte[] CilBody(this DynamicDelegate src)
            => src.DynamicMethod.CilBody();

        public static byte[] CilBody<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => src.DynamicMethod.CilBody();

        public static CilFunction CilFunc(this DynamicMethod src)
            => CilFunction.From(src);

        public static CilFunction CilFunc(this DynamicDelegate src)
            => src.DynamicMethod.CilFunc();

        public static CilFunction CilFunc<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => src.DynamicMethod.CilFunc();

        /// <summary>
        /// JIT's the delegate and returns a pointer to the native body
        /// </summary>
        /// <param name="d">The delegate to JIT</param>
        public static DynamicPointer Jit(this DynamicDelegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d.DynamicOp);
            return d.GetDynamicPointer();
        }

        /// <summary>
        /// JIT's the delegate and returns a pointer to the native body
        /// </summary>
        /// <param name="d">The delegate to JIT</param>
        public static DynamicPointer Jit<D>(this DynamicDelegate<D> d)
            where D : Delegate
        {   
            RuntimeHelpers.PrepareDelegate(d.DynamicOp);
            return d.GetDynamicPointer();
        }
    }
}
