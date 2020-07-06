//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;    

    public readonly struct FunctionPointer : IFunctionPointer
    {
        public static FunctionPointer Service => default;

        /// <summary>
        /// Creates a dynamic pointer from an untyped dynamic delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="handle">A proxy for the unmanaged pointer</param>
        [MethodImpl(Inline)]
        public static DynamicPointer from(DynamicDelegate src)
            => DynamicPointer.From(src);

        /// <summary>
        /// Creates a dynamic pointer from a generic dynamic delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="handle">A proxy for the unmanaged pointer</param>
        /// <typeparam name="D">The delegate type</typeparam>
        [MethodImpl(Inline)]
        public static DynamicPointer from<D>(DynamicDelegate<D> src)
            where D : Delegate
                => from(src);
    }
}