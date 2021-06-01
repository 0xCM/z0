//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class gbits
    {
        /// <summary>
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="index">The index at which to begin disabling target bits</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), MsbOff, Closures(Closure)]
        public static T msboff<T>(T src, byte index)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.msboff(uint8(src), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.msboff(uint16(src), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.msboff(uint32(src), index));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.msboff(uint64(src),index));
            else
                throw no<T>();
        }
    }
}