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
        /// Extracts a scalar value from a bitspan
        /// </summary>
        /// <param name="src">The bitspan source</param>
        /// <param name="offset">The source index to begin extraction</param>
        /// <param name="count">The number of source bits that contribute to the extract</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T extract32<T>(in BitSpan32 src, int offset = 0)
            where T : unmanaged
                => extract32_u<T>(src,offset);

        [MethodImpl(Inline)]
        static T extract32_u<T>(in BitSpan32 src, int offset = 0)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(SB.extract32(src, n8, offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(SB.extract32(src, n16, offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(SB.extract32(src, n32, offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(SB.extract32(src, n64, offset));
            else
                return extract32_i<T>(src,offset);
        }

        [MethodImpl(Inline)]
        static T extract32_i<T>(in BitSpan32 src, int offset = 0)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return force<T>(SB.extract32(src, n8, offset));
            else if(typeof(T) == typeof(short))
                return force<T>(SB.extract32(src, n16, offset));
            else if(typeof(T) == typeof(int))
                return force<T>(SB.extract32(src, n32, offset));
            else if(typeof(T) == typeof(long))
                return force<T>(SB.extract32(src, n64, offset));
            else
                throw no<T>();
        }
    }
}