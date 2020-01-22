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
        /// Returns a pointer to the native content of a dynamic method
        /// </summary>
        /// <param name="method">The source method</param>
        public static IntPtr NativePointer(this DynamicMethod method)
            => NativeCapture.pointer(method);

        /// <summary>
        /// Returns a dynamic delegate's dynamic pointer
        /// </summary>
        /// <param name="src">The source delegate</param>
        public static unsafe DynamicPointer GetDynamicPointer(this DynamicDelegate src)
            => Dynop.ptr(src);

        /// <summary>
        /// Returns a dynamic delegate's dynamic pointer
        /// </summary>
        /// <param name="src">The source delegate</param>
        public static unsafe DynamicPointer GetDynamicPointer<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => Dynop.ptr(src);

        public static CilFunctionBody CilFunc(this DynamicMethod src)
            => CilFunctionBody.From(src);

        public static CilFunctionBody CilFunc(this MethodInfo src)
            => CilFunctionBody.From(src);

        public static CilFunctionBody CilFunc(this DynamicDelegate src)
            => CilFunctionBody.From(src);

        public static CilFunctionBody CilFunc<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => CilFunctionBody.From(src);

        internal static DynamicDelegate<D> CreateDelegate<D>(this DynamicMethod dst, Moniker id,  MethodInfo src)
            where D : Delegate
                => DynamicDelegate.Define(id, src,dst, (D)dst.CreateDelegate(typeof(D)));

        internal static DynamicDelegate CreateDelegate(this DynamicMethod dst, Moniker id, MethodInfo src, Type @delegate)
            => DynamicDelegate.Define(id, src,dst, dst.CreateDelegate(@delegate));
    }
}