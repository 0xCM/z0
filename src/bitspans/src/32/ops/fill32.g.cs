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

    partial class BitSpans32
    {
        /// <summary>
        /// Fills a bitspan from a primal source
        /// </summary>
        /// <param name="src">The packed source bits</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly BitSpan32 fill32<T>(T src, in BitSpan32 dst)
            where T : unmanaged
                => ref fill32_u(src,dst);

        [MethodImpl(Inline)]
        static ref readonly BitSpan32 fill32_u<T>(T src, in BitSpan32 dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return ref SB.fill32(uint8(src),dst);
            else if(typeof(T) == typeof(ushort))
                return ref SB.fill32(uint16(src),dst);
            else if(typeof(T) == typeof(uint))
                return ref SB.fill32(uint32(src),dst);
            else if(typeof(T) == typeof(ulong))
                return ref SB.fill32(uint64(src),dst);
            else
                return ref fill32_i(src, dst);
        }

        [MethodImpl(Inline)]
        static ref readonly BitSpan32 fill32_i<T>(T src, in BitSpan32 dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return ref SB.fill32(Numeric.force<T,byte>(src),dst);
            else if(typeof(T) == typeof(short))
                return ref SB.fill32(Numeric.force<T,ushort>(src),dst);
            else if(typeof(T) == typeof(int))
                return ref SB.fill32(Numeric.force<T,uint>(src),dst);
            else if(typeof(T) == typeof(long))
                return ref SB.fill32(Numeric.force<T,ulong>(src),dst);
            else
                throw no<T>();
        }
    }
}