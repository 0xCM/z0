//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed;
    using static Memories;

    partial class BitPack
    {
        /// <summary>
        /// Unpacks each primal source bit to a 32-bit target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void unpack<T>(T src, Span<uint> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                unpack(uint8(src), dst);
            else if(typeof(T) == typeof(ushort))
                unpack(uint16(src), dst);
            else if(typeof(T) == typeof(uint))
                unpack(uint32(src), dst);
            else if(typeof(T) == typeof(ulong))
                unpack(uint64(src), dst);
            else
                throw Unsupported.define<T>();
        }
    }
}