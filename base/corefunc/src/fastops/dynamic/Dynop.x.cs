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
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class DynamicX
    {
        /// <summary>
        /// Finds the magical function pointer for a dynamic method
        /// </summary>
        /// <param name="method">The source method</param>
        /// <remarks>See https://stackoverflow.com/questions/45972562/c-sharp-how-to-get-runtimemethodhandle-from-dynamicmethod</remarks>
        public static IntPtr NativePointer(this DynamicMethod method)
        {
            var descriptor = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return ((RuntimeMethodHandle)descriptor.Invoke(method, null)).GetFunctionPointer();
        }

        /// <summary>
        /// Returns a dynamic delegate's dynamic pointer
        /// </summary>
        /// <param name="src">The source delegate</param>
        public static unsafe DynamicPointer GetDynamicPointer(this DynamicDelegate src)
            => src.ToDynamicPtr();

        /// <summary>
        /// Returns a dynamic delegate's dynamic pointer
        /// </summary>
        /// <param name="src">The source delegate</param>
        public static unsafe DynamicPointer GetDynamicPointer<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => src.ToDynamicPtr();

        public static CilFunctionBody CilFunc(this DynamicMethod src)
            => CilFunctionBody.From(src);

        public static CilFunctionBody CilFunc(this MethodInfo src)
            => CilFunctionBody.From(src);

        public static CilFunctionBody CilFunc(this DynamicDelegate src)
            => CilFunctionBody.From(src);

        public static CilFunctionBody CilFunc<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => CilFunctionBody.From(src);

        internal static DynamicDelegate<D> CreateDelegate<D>(this DynamicMethod dst, OpIdentity id,  MethodInfo src)
            where D : Delegate
                => DynamicDelegate.Define(id, src,dst, (D)dst.CreateDelegate(typeof(D)));

        internal static DynamicDelegate CreateDelegate(this DynamicMethod dst, OpIdentity id, MethodInfo src, Type @delegate)
            => DynamicDelegate.Define(id, src, dst, dst.CreateDelegate(@delegate));
    }
}