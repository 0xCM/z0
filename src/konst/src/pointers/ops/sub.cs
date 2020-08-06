//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    unsafe partial struct Pointers
    {
        /// <summary>
        /// Reverses the source by a byte-measured offset
        /// </summary>
        /// <param name="src">The source pointer</param>
        /// <param name="size">The offset size in bytes</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Ptr<T> sub<T>(in Ptr<T> src, uint size)
            where T : unmanaged
        {
            ref var dst = ref z.edit(src);
            dst.P = Unsafe.AddByteOffset(ref dst, (IntPtr)(-(int)size));
            return ref dst;
        }
    }
}