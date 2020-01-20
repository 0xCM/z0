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
            => DynamicPointer.From(src);

        /// <summary>
        /// Returns a dynamic delegate's dynamic pointer
        /// </summary>
        /// <param name="src">The source delegate</param>
        public static unsafe DynamicPointer GetDynamicPointer<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => DynamicPointer.From(src);

        public static CilFunctionBody CilFunc(this DynamicMethod src)
            => CilFunctionBody.From(src);

        public static CilFunctionBody CilFunc(this MethodInfo src)
            => CilFunctionBody.From(src);

        public static CilFunctionBody CilFunc(this DynamicDelegate src)
            => CilFunctionBody.From(src);

        public static CilFunctionBody CilFunc<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => CilFunctionBody.From(src);

        internal static DynamicDelegate<D> CreateDelegate<D>(this DynamicMethod dst, MethodInfo src)
            where D : Delegate
                => DynamicDelegate.Define(src,dst, (D)dst.CreateDelegate(typeof(D)));

        internal static DynamicDelegate CreateDelegate(this DynamicMethod dst, MethodInfo src, Type @delegate)
                => DynamicDelegate.Define(src,dst, dst.CreateDelegate(@delegate));

        internal static ILGenerator EmitConstLoad(this ILGenerator g, byte imm)
        {
            var code = imm switch {
                0 => OpCodes.Ldc_I4_0,
                1 => OpCodes.Ldc_I4_1,
                2 => OpCodes.Ldc_I4_2,
                3 => OpCodes.Ldc_I4_3,
                4 => OpCodes.Ldc_I4_4,
                5 => OpCodes.Ldc_I4_5,
                6 => OpCodes.Ldc_I4_6,
                7 => OpCodes.Ldc_I4_7,
                8 => OpCodes.Ldc_I4_8,
                _ => OpCodes.Ldc_I4_S
            }; 
            if(imm <= 8)
                g.Emit(code);
            else
                g.Emit(code, imm);

            return g;
        }
    }
}