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

    public static class DynamicOps
    {
        /// <summary>
        /// Constructs the dynamic pointer determined by the source delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        [MethodImpl(Inline)]
        public static unsafe DynamicPointer GetDynamicPointer<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => DynamicPointer.Define(src, src.Target.GetNativePointer());

        /// <summary>
        /// Returns a dynamic delegate's dynamic pointer
        /// </summary>
        /// <param name="src">The source delegate</param>
        [MethodImpl(Inline)]
        public static unsafe DynamicPointer GetDynamicPointer(this DynamicDelegate src)
            => DynamicPointer.Define(src, src.TargetMethod.GetNativePointer());

        /// <summary>
        /// Finds the magical function pointer for a dynamic method
        /// </summary>
        /// <param name="method">The source method</param>
        /// <remarks>See https://stackoverflow.com/questions/45972562/c-sharp-how-to-get-runtimemethodhandle-from-dynamicmethod</remarks>
        public static IntPtr GetNativePointer(this DynamicMethod method)
        {
            var descriptor = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return ((RuntimeMethodHandle)descriptor.Invoke(method, null)).GetFunctionPointer();
        }

        [MethodImpl(Inline)]
        public static CilBody LoadCil(this DynamicMethod src)
            => CilBody.Load(src);

        [MethodImpl(Inline)]
        public static CilBody LoadCil(this MethodInfo src)
            => CilBody.Load(src);

        [MethodImpl(Inline)]
        public static CilBody LoadCil(this DynamicDelegate src)
            => CilBody.Load(src);

        [MethodImpl(Inline)]
        public static CilBody LoadCil<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => CilBody.Load(src); 
    }
}