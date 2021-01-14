//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ClrDynamic
    {
        /// <summary>
        /// Creates a dynamic pointer from an untyped dynamic delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="handle">A proxy for the unmanaged pointer</param>
        [MethodImpl(Inline), Op]
        public static DynamicPointer pointer(DynamicDelegate src)
            => pointer(src, pointer(src.Target));

        [MethodImpl(Inline), Op]
        public static DynamicPointer pointer(DynamicDelegate src, IntPtr handle)
            => new DynamicPointer(src, handle);

        /// <summary>
        /// Creates a dynamic pointer from a generic dynamic delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="handle">A proxy for the unmanaged pointer</param>
        /// <typeparam name="D">The delegate type</typeparam>
        public static DynamicPointer pointer<D>(DynamicDelegate<D> src)
            where D : Delegate
                => pointer(src);
    }
}
