//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class gbits
    {
        /// <summary>
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="index">The index at which to begin disabling target bits</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), ZHi, Closures(UnsignedInts)]
        public static T zhi<T>(T src, int index)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.zhi(uint8(src), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.zhi(uint16(src), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.zhi(uint32(src), index));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.zhi(uint64(src),index));
            else
                throw Unsupported.define<T>();
        }
    }
}