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

    using SB = SpannedBits;

    partial class BitSpans
    {
        /// <summary>
        /// Creates a bitspan from a primal source
        /// </summary>
        /// <param name="src">The packed source bits</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BitSpan32 from32<T>(T src)
            where T : unmanaged
                => from32_u(src);

        /// <summary>
        /// Creates a bitspan from a primal source, or portion thereof
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="maxbits">The maximum number of bits to draw from the source</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BitSpan32 from32<T>(T src, int maxbits)
            where T : unmanaged
        {
            var dst = from32(src);
            return (dst.Length > maxbits && maxbits != 0) ? load32(dst.Data.Slice(0, maxbits)) : dst;
        }

        [MethodImpl(Inline)]
        static BitSpan32 from32_u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return SB.from32(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return SB.from32(uint16(src));
            else if(typeof(T) == typeof(uint))
                return SB.from32(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return SB.from32(uint64(src));
            else
                return from32_i(src);
        }

        [MethodImpl(Inline)]
        static BitSpan32 from32_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return SB.from32(z.force<T,byte>(src));
            else if(typeof(T) == typeof(short))
                return SB.from32(z.force<T,ushort>(src));
            else if(typeof(T) == typeof(int))
                return SB.from32(z.force<T,uint>(src));
            else if(typeof(T) == typeof(long))
                return SB.from32(z.force<T,ulong>(src));
            else
                throw no<T>();
        }
    }
}